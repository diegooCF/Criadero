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
        public Dog Dog { get; set; }
        public DateTime DayOfApplication { get; set; }
        public string Comments { get; set; }

        public SupplyApplication(T Supply, Dog Dog, DateTime DayOfApplication, string Comments)
        {
            this.Supply= Supply;
            this.Dog = Dog;
            this.DayOfApplication = DayOfApplication;
            this.Comments = Comments;
        }
    }
}
