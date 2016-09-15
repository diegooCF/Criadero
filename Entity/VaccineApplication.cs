using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class VaccineApplication : SupplyApplication<Vaccine>
    {
        public VaccineApplication(Vaccine Vaccine, Dog Dog, DateTime DayOfApplication, string Comments) 
            : base(Vaccine, Dog, DayOfApplication, Comments) { }        
    }
}
