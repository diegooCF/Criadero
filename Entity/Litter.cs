using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Litter
    {
        private List<Puppy> Puppies = new List<Puppy>();
        public int Males { get; set; }
        public int Females { get; set; }

        //TODO Deploy the constructor
        public Litter() { }
        //TODO Doesn't sure if this validation should be in the Logic layer
        public void addPuppie(Puppy puppy)
        {
            Puppies.Add(puppy);
            if (puppy.Gender == Enums.Gender.MALE)
                Males++;
            else
                Females++;
        }
    }
}
