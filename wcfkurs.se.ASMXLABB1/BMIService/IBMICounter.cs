using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace BMIService
{
    [ServiceContract(Namespace = "http://BMIService")]
    public interface IBMICounter
    {
        [OperationContract]
        float CalculateBMI(float weight, float height);
    }
}
