using Logger.LoggerDestinations;

namespace Logger
{
    public class SimpleLogger : ILogger
    {
        private readonly ILogger destination;

        public SimpleLogger()
        {
            destination = new ConsoleLogger();
        }

        public SimpleLogger(ILogger destination)
        {
            this.destination = destination;
        }

        public void Error(string message)
        {
            destination.Error(message);
        }

        public void Error(Exception exception)
        {
            destination.Error(exception);
        }

        public void Info(string message)
        {
            destination.Info(message);
        }

        public void Warning(string message)
        {
            destination.Warning(message);
        }
    }
}
