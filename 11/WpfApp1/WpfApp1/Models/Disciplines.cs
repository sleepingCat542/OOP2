using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Disciplines
    {
        public string Name { get; set; }
        public string Lector { get; set; }
        public int Hours { get; set; }
        public int Liseners { get; set; }
        public int Count { get; set; }

        public Disciplines(string name, string lector, int hours, int liseners)
        {
            this.Name = name;
            this.Lector = lector;
            this.Hours = hours;
            this.Liseners = liseners;
            this.Count = liseners;
        }
    }
}
