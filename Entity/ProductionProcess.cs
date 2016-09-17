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
        public Zeal Zeal { get; set; }
        public DateTime StartDate { get; set; }
        public string Comments { get; set; }
        public DateTime EstimatedFinishDate { get; set; } //Estimated Birth Date

        public ProductionProcess(ServiceSet ServiceSet, DateTime StartDate)
        {
            this.ServiceSet = ServiceSet;
            this.StartDate = StartDate;
        }
    }
}
