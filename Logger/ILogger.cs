namespace Logger
{
    public interface ILogger
    {
        void Error(string message);
        void Error(Exception exception);
        void Warning(string message);
        void Info(string message);
    }
}
