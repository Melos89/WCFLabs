using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIService
{
    public class BMICounterService : IBMICounter
    {
        public float CalculateBMI(float weightinKilos, float heightinCentimetres)
        {
            return (weightinKilos / heightinCentimetres) * weightinKilos;
        }
    }
}
