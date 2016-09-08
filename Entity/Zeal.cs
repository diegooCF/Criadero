using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Enums;

namespace Entity
{
    public class Zeal
    {
        public Dog Female
        {
            get { return Female; }
            set
            {
                if(value.Equals(Gender.FEMALE))
                {
                    Female = value;
                }
                else
                {
                    throw new Exception("El animal seleccionado no es una hembra");
                }
            }
        }
        public DateTime StartDate { get; set; }

        public Zeal() { }
        public Zeal(Dog Female, DateTime StartDate)
        {
            this.Female = Female;
            this.StartDate = StartDate;
        }
    }
}
