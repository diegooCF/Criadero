using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Nativity
    {
        private Litter Litter { get; set; }
        private DateTime EstimatedDateStart { get; set; }
        private string Comments { get; set; }

        /// <summary>
        /// This constructor only receives a variable that especifies a possible Nativity
        /// </summary>
        /// <param name="EstimatedDateStart">Indicates the possible start date of the nativity</param>
        public Nativity(DateTime EstimatedDateStart)
        {
            this.EstimatedDateStart = EstimatedDateStart;
        }

        public void finish(Litter litter, string Comments)
        {
            this.Litter = Litter;
            this.Comments = Comments;
        }
    }
}
