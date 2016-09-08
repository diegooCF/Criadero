using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Enums;

namespace Entity
{
    public class Puppy : Dog
    {
        public Dog Mother { get; set; }
        public Dog Father { get; set; }
        public double BirthWeight { get; set; }
        public string Comment { get; set; }

        /// <summary>
        /// This Puppy constructor calls his parent constructor and pass it the Data that has received
        /// </summary>
        /// <param name="NameReal"></param>
        /// <param name="NameFormal"></param>
        /// <param name="BirthDate"></param>
        /// <param name="Gender"></param>
        /// <param name="Breed"></param>
        /// <param name="Color"></param>
        /// <param name="Mother"></param>
        /// <param name="Father"></param>
        public Puppy(string NameReal, string NameFormal, DateTime BirthDate, Gender Gender, Breed Breed, 
                     Color Color, Dog Mother, Dog Father, double BirthWeight, string Comment) 
                     : base(NameReal,NameFormal,BirthDate,Gender,Breed,Color)
        {
            this.Mother = Mother;
            this.Father = Father;
            this.BirthWeight = BirthWeight;
            this.Comment = Comment;
        }
    }
}
