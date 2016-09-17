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
        public DateTime Date { get; set; }

        public Service(Dog Male, DateTime Date)
        {
            this.Male = Male;
            this.Date = Date;
        }
    }
}
