using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherrezProgreso3.Model
{
    public class AC_UserRandom
    {
        public class Info
        {
            public string seed { get; set; }
            public string results { get; set; }
            public string page { get; set; }
            public string version { get; set; }
            public Time time { get; set; }
            public User user { get; set; }
        }

        public class Result
        {
            public string name { get; set; }
            public int age { get; set; }
            public string phone { get; set; }
        }

        public class Root
        {
            public List<Result> results { get; set; }
            public Info info { get; set; }
        }

        public class Time
        {
            public int instruct { get; set; }
            public int generate { get; set; }
        }

        public class User
        {
            public string username { get; set; }
            public string tier { get; set; }
            public string results { get; set; }
            public string remaining { get; set; }
        }
    }
}
