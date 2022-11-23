using Logger.LoggerDestinations;

namespace Logger
{
    public class SimpleLogger : ILogger
    {
        private readonly ILoggerDestination destination;

        public SimpleLogger(Destinations destinations)
        {
            destination = destinations switch
            {
                Destinations.Console => new ConsoleLogger(),
                _ => throw new ArgumentOutOfRangeException(nameof(destinations), destinations, null)
            };
        }

        public void Error(string message)
        {
            var messageToLog = $"[Error] {message}";
            destination.Log(messageToLog);
        }

        public void Error(Exception exception)
        {
            var messageToLog = $"[Error] {exception.Message}";
            destination.Log(messageToLog);
        }

        public void Info(string message)
        {
            var messageToLog = $"[Info] {message}";
            destination.Log(messageToLog);
        }

        public void Warning(string message)
        {
            var messageToLog = $"[Warning] {message}";
            destination.Log(messageToLog);
        }
    }
}
