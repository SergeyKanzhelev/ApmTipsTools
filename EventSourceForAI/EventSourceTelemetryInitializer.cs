namespace EventSourceForAI
{
    using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

    public class EventSourceTelemetryInitializer : ITelemetryInitializer
    {
        private readonly EventSourceOptions eventSourceOptions;
        private readonly EventSource eventSource;

        public EventSourceTelemetryInitializer()
        {
            this.eventSource = new EventSource(
                "Microsoft.ApplicationInsights",
                EventSourceSettings.EtwSelfDescribingEventFormat,
                "ETW_GROUP",
                "{0d943590-b235-5bdb-f854-89520f32fc0b}");

            this.eventSourceOptions = new EventSourceOptions() { Keywords = (EventKeywords)0x2000000000000 };

        }

        public void Initialize(ITelemetry telemetry)
        {
            if (telemetry is RequestTelemetry)
            {
                var request = telemetry as RequestTelemetry;

                var requestData = new RequestData();
                requestData.duration = request.Duration.ToString();
                requestData.httpMethod = request.HttpMethod;
                requestData.id = request.Id;
                requestData.name = request.Name;
                requestData.responseCode = request.ResponseCode;
                requestData.startTime = request.StartTime.ToString();
                requestData.success = request.Success;
                requestData.url = request.Url == null ? "" : request.Url.ToString();
                requestData.properties = request.Properties;

                var tags = new Dictionary<string, string>();

                var userCtx = new UserContextData(tags);
                userCtx.AccountId = request.Context.User.AccountId;
                userCtx.AcquisitionDate = request.Context.User.AcquisitionDate;
                userCtx.Id = request.Context.User.Id;
                userCtx.UserAgent = request.Context.User.UserAgent;

                var operationCtx = new OperationContextData(tags);
                operationCtx.Id = request.Context.Operation.Id;
                operationCtx.Name = request.Context.Operation.Name;

                this.WriteEvent("Request", request.Context.InstrumentationKey, tags, requestData);

                ApplicationInsightsEventSource.Log.RequestSent(request.Context.InstrumentationKey, request.Name, request.Id);
            }
        }

        internal void WriteEvent<T>(string eventName, string instrumentationKey, IDictionary<string, string> tags, T data)
        {
            this.eventSource.Write(eventName, this.eventSourceOptions, new { PartA_iKey = instrumentationKey, PartA_Tags = tags, _B = data });
        }

    }
}
