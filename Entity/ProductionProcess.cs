using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductionProcess
    {
        public ServiceSet ServiceSet { get; set; }
        public DateTime StartDate { get; set; }
        public Nativity Nativity { get; set; }
        public string Comments { get; set; }
        public Enums.Rating Rating { get; set; }

        public ProductionProcess(ServiceSet ServiceSet, Nativity Nativity)
        {
            this.ServiceSet = ServiceSet;
            //The StartDate will be defined by the first Service in the ServiceSet
            this.StartDate = ServiceSet.Services.ElementAt(0).Date;
            this.Nativity = Nativity;
        }

        public void finishProductionProcess(Litter Litter)
        {
            //TODO Deploy the finishProductionProcess
        }
    }
}
