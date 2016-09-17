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

        private List<SupplyApplication<Deworming>> AppliedDewormings { get; set; }
        private List<SupplyApplication<Vaccine>> AppliedVaccines { get; set; }

        public Dog() { }
        public Dog(string NameReal, string NameFormal, DateTime BirthDate, Gender Gender, Breed Breed, Color Color)
        {
            this.NameReal = NameReal;
            this.NameFormal = NameFormal;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
            this.Breed = Breed;
            this.Color = Color;

            AppliedDewormings = new List<SupplyApplication<Deworming>>();
            AppliedVaccines = new List<SupplyApplication<Vaccine>>();
        }

        /// <summary>
        /// Apply a new Deworming
        /// </summary>
        /// <param name="application">New Application with respective data</param>
        public void applyDeworming(SupplyApplication<Deworming> application)
        {
            AppliedDewormings.Add(application);
        }

        /// <summary>
        /// Apply a new Vaccine
        /// </summary>
        /// <param name="application">New Application with respective data</param>
        public void applyVaccine(SupplyApplication<Vaccine> application)
        {
            AppliedVaccines.Add(application);
        }     
    }
}
