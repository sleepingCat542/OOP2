using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.FormOwner;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Owner
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MidName { get; set; }
        public string Birthday { get; set; }
        public string passportSeries { get; set; }
        [PersonNumberAttribute]
        public string passportId { get; set; }
        public Owner() { }
        public  Owner(string name, string surn, string midN, string day, string PS, string PID)
        {
            Name = name;
            Surname = surn;
            MidName = midN;
            Birthday = day;
            passportSeries = PS;
            passportId = PID;
        }
    }
}
