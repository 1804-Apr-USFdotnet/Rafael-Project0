using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace RestarauntReviews.bl
{
    class ErrorManager : IErrorManager
    {
        public void logError(Exception ex, string customMessage)
        {

            Logger logger = LogManager.GetLogger("databaseLogger");

            // add custom message and pass in the exception
            logger.Error(ex, customMessage);

        }
    }
}
