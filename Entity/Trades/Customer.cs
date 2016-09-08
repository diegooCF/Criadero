using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Enums;

namespace Entity.Trades
{
    public class Customer
    {
        public string Name { get; set; }
        public string Last { get; set; }
        public List<string> Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public Rating Rating { get; set; }

        /// <summary>
        /// This constructor set a new Customer and his first purchase
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Last"></param>
        /// <param name="Phone"></param>
        /// <param name="Mail"></param>
        /// <param name="Address"></param>
        /// <param name="Comment"></param>
        /// <param name="Purchase"></param>
        public Customer(string Name, string Last, List<string> Phone, string Mail, string Address, 
                        string Comment, Rating Rating)
        {
            this.Name = Name;
            this.Last = Last;
            this.Phone = Phone;
            this.Mail = Mail;
            this.Address = Address;
            this.Comment = Comment;
            this.Rating = Rating;
        }

    }
}
