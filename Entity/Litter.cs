using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Litter
    {
        public List<Puppy> Puppies = new List<Puppy>();
        public ServiceSet ServiceSet { get; set; }
        public DateTime BirthDate { get; set; }

        public Litter(ServiceSet ServiceSet, DateTime BirthDate)
        {
            this.ServiceSet = ServiceSet;
        }

        public void addPuppie(Puppy puppy)
        {
            Puppies.Add(puppy);
        }
    }
}
