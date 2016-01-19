using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeService
{
    public class AgeCheckerService : IAgeChecker
    {
        public double AgeInDays(DateTime date)
        {
            var now = DateTime.Now;
            var resultAge = now - date;
            return resultAge.TotalDays;
        }

        public double AgeInHours(DateTime date)
        {
            var now = DateTime.Now;
            var resultAge = now - date;
            return resultAge.TotalHours;
        }

        public double AgeInYears(DateTime date)
        {
            var now = DateTime.Now;
            var resultAge = now.Year - date.Year;
            return resultAge;
        }
    }
