using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace Cotraser.Isoa.Common.Exception
{
    public class ExceptionPolicy
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
 
        public static void HandleException(System.Exception ex)
        {
            logger.Error(string.Format(
                "{0}\n\r{1}"
                , ex.Message
                , ex.StackTrace));
        }

        public static void HandleException(System.Exception ex, bool rethrow)
        {
            logger.Error(string.Format(
                "{0}\n\r{1}"
                , ex.Message
                , ex.StackTrace));

            if (rethrow)
                throw ex;
        }
    }
}
