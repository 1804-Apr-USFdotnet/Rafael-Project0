using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntReviews.bl
{
    interface IErrorManager
    {

       void logError(Exception ex, string customMessage);

    }
}
