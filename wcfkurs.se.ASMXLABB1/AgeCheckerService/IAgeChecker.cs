using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace AgeService
{
    [ServiceContract(Namespace = "http://AgeCheckerService")]
    public interface IAgeChecker
    {
        [OperationContract]
        double AgeInYears(DateTime date);
        [OperationContract]
        double AgeInDays(DateTime date);
        [OperationContract]
        double AgeInHours(DateTime date);
    }
}
