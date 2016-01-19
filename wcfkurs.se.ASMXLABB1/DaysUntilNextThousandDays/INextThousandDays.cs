using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace DaysUntilNextThousandDays
{
    [ServiceContract(Namespace = "DaysUntilNextThousandDays")]
    public interface INextThousandDays
    {
        [OperationContract]
        DateTime DaysToGo(DateTime date);
    }
}
