using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestEventSource
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = TelemetryConfiguration.CreateDefault();
            config.TelemetryInitializers.Add(new EventSourceForAI.EventSourceTelemetryInitializer());
            config.InstrumentationKey = "Foo";

            TelemetryClient client = new TelemetryClient(config);

            var request = new RequestTelemetry("TestRequest", DateTimeOffset.Now, TimeSpan.FromMilliseconds(10), "200", true);
            request.Context.Properties.Add("property1", "value1");
            request.Context.User.Id = "userId";

            request.Context.Operation.Id = Guid.NewGuid().ToString();

            client.TrackRequest(request);

            Thread.Sleep(100);
        }
    }
}
