using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DewormingApplication : SupplyApplication<Deworming>
    {
        public DewormingApplication(Deworming Deworming, Dog Dog, DateTime DayOfApplication, string Comments) 
            : base(Deworming, Dog, DayOfApplication, Comments) { }
    }
}
