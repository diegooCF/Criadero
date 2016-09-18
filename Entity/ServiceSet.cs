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
        public DateTime StartDate { get; set; }
        public List<Service> Services { get; set; }
        public string Comments { get; set; }

        public ServiceSet(Dog Male, Dog Female, DateTime StartDate, string Comments)
        {
            this.Male = Male;
            this.Female = Female;
            this.StartDate = StartDate;
            this.Comments = Comments;
            Services = new List<Service>();

            //We set the StartDate as FirstService
            addService(new Service(Male, StartDate));
        } 

        public void addService(Service Service)
        {
            Services.Add(Service);
        }
    }
}
