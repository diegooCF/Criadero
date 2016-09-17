using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SupplyApplication<T>
    {
        public T Supply { get; set; }
        public DateTime DayOfApplication { get; set; }
        public string Comments { get; set; }

        public SupplyApplication(T Supply, DateTime DayOfApplication, string Comments)
        {
            this.Supply= Supply;
            this.DayOfApplication = DayOfApplication;
            this.Comments = Comments;
        }
    }
}
