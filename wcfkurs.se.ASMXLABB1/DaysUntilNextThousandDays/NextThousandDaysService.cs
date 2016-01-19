using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysUntilNextThousandDays
{
    public class NextThousandDaysService : INextThousandDays
    {
        public int DaysToGo(DateTime date)
        {
            var today = DateTime.Now;
            var resultTime = (today - date).TotalDays;


        }
    }
}
