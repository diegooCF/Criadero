using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServiceSet
    {
        public Dog Male { get; set; }
        public Dog Female { get; set; }
        public Zeal Zeal { get; set; }
        public List<DateTime> Service { get; set; }
        public string Comments { get; set; }

        public ServiceSet() { }
        public ServiceSet(Dog Male, Dog Female, Zeal Zeal, string Comments)
        {
            this.Male = Male;
            this.Female = Female;
            this.Zeal = Zeal;
            this.Comments = Comments;
            Service = new List<DateTime>();
        } 

        public void addService(DateTime dateService)
        {
            Service.Add(dateService);
        }
    }
}
