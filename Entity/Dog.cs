using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Enums;

namespace Entity
{
    public class Dog
    {
        public string NameReal { get; set; }
        public string NameFormal { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public Breed Breed { get; set; }
        public Color Color { get; set; }
        public List<DewormingApplication> AppliedDewormings { get; set; }
        public List<VaccineApplication> AppliedVaccines { get; set; }

        public Dog() { }
        public Dog(string NameReal, string NameFormal, DateTime BirthDate, Gender Gender, Breed Breed, Color Color)
        {
            this.NameReal = NameReal;
            this.NameFormal = NameFormal;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
            this.Breed = Breed;
            this.Color = Color;

            AppliedDewormings = new List<DewormingApplication>();
            AppliedVaccines = new List<VaccineApplication>();
        }

        public void applyVaccine(VaccineApplication application)
        {
            AppliedVaccines.Add(application);
        }

        public void applyDeworming(DewormingApplication application)
        {
            AppliedDewormings.Add(application);
        }
    }
}
