namespace EventSourceForAI
{
    using System.Diagnostics.Tracing;

    internal class ApplicationInsightsEventSource : EventSource
    {
        public static ApplicationInsightsEventSource Log = new ApplicationInsightsEventSource();

        [Event(1, Level = EventLevel.Informational)]
        public void RequestSent(string instrumentationKey, string name, string id)
        {
            this.WriteEvent(1, instrumentationKey, name, id);
        }
    }
}
