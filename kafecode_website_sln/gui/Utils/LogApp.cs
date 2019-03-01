using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace gui.Utils
{
    public static class LogApp
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Error(string currentMethod, string message, Exception exception)
        {
            log.Error($"ERROR en {currentMethod} , Detalle: {message}", exception);
        }

        public static void FatalError(string currentMethod, string message, Exception exception)
        {
            log.Fatal($"ERROR FATAL en {currentMethod} , Detalle: {message}", exception);
        }

        public static void Info(string currentMethod, string message)
        {
            log.Debug($"Mostrando información en {currentMethod} , Detalle: {message}");
        }

        public static void Debug(string currentMethod, string message)
        {
            log.Debug($"Debug en {currentMethod} , Detalle: {message}");
        }

    }
}