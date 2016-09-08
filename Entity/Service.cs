using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Service
    {
        public Dog Male { get; set; }
        public Dog Female { get; set; }
        public Zeal Zeal { get; set; }
        public List<DateTime> Services { get; set; }

        public Service() { }
        public Service(Dog Male, Dog Female, Zeal Zeal)
        {
            this.Male = Male;
            this.Female = Female;
            this.Zeal = Zeal;
            Services = new List<DateTime>();
        } 
    }
}
