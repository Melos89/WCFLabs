using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysUntilNextThousandDays
{
    public class NextThousandDaysService : INextThousandDays
    {
        public DateTime DaysToGo(DateTime dateOfBirth)
        {
            var now = DateTime.Now;

            var resultInDays = (now - dateOfBirth).TotalDays;

            var moduloresult = resultInDays % 1000;

            var daysUntilNext = 1000 - (int)moduloresult;

            var date = now.AddDays(daysUntilNext);

            return date;
        }
    }
}
