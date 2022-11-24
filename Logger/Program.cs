using Logger;

var logger = new SimpleLogger();

logger.Info("Testing info log");
logger.Error(new ArgumentNullException("Testing exception error"));
logger.Warning("Warning test...");