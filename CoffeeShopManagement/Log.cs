using NLog;

namespace CoffeeShopManagement
{
    public static class Log
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void Debug(string message)
        {
            logger.Debug(message);
        }
        public static void Info(string message)
        {
            logger.Info(message);
        }
        public static void Error(string message)
        {
            logger.Error(message);
        }
    }
}
