namespace Logger.LoggerDestinations
{
    public class ConsoleLogger : ILogger
    {
        public void Error(string message)
        {
            Log(LogLevel.Error, message);
        }

        public void Error(Exception exception)
        {
            Log(LogLevel.Error, $"Type: {exception.GetType()} Message: {exception.Message}");
        }

        public void Info(string message)
        {
            Log(LogLevel.Info, message);
        }

        public void Warning(string message)
        {
            Log(LogLevel.Warning, message);
        }

        private void Log(LogLevel logLevel, string message)
        {
            var stringLogLevel = Utils.AssignLogLevel(logLevel);
            Console.WriteLine($"{stringLogLevel} {DateTime.Now}, {message}");
        }

        
    }
}
