using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATT_API.Models
{
    public class Jockey
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public int RealAge { get; set; }
        public string DOBString { get; set; }
    }
}