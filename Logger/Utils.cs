namespace Logger
{
    public static class Utils
    {
        public static string AssignLogLevel(LogLevel logLevel)
        {
            return logLevel switch
            {
                LogLevel.Error => "[Error]",
                LogLevel.Warning => "[Warning]",
                LogLevel.Info => "[Info]",
                _ => throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, null)
            };
        }
    }
}
