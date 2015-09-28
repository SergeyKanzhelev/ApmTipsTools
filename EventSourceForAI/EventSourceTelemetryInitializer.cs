namespace EventSourceForAI
{
    using Microsoft.ApplicationInsights.Extensibility;
    using Microsoft.ApplicationInsights.Channel;
    using Microsoft.ApplicationInsights.DataContracts;

    public class EventSourceTelemetryInitializer : ITelemetryInitializer
    {
        public void Initialize(ITelemetry telemetry)
        {
            if (telemetry is RequestTelemetry)
            {
                var request = telemetry as RequestTelemetry;
                ApplicationInsightsEventSource.Log.RequestSent(request.Context.InstrumentationKey, request.Name, request.Id);
            }
        }
    }
}
