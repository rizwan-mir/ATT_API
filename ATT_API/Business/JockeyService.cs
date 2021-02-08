using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ATT_API.Interface;

namespace ATT_API.Business
{
    public class JockeyService : IJockey
    {
        public int GetRealAge(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age = age - 1;
            return age;
        }
    }
}