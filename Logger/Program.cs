using Logger;
using Logger.LoggerDestinations;

var logger = new SimpleLogger(Destinations.Console);

logger.Info("Logger is working...");