using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Enums;

namespace Entity.Trades
{
    public class Purchase
    {
        public Customer Customer { get; set; }
        public Puppy Puppy { get; set; }
        public double Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public WayToPay Payment { get; set; }
        public string Comment { get; set; }

        public Purchase(Customer Customer, Puppy Puppy, double Amount, DateTime PurchaseDate, DateTime DeliveryDate,
                        WayToPay Payment, string Comment)
        {
            this.Customer = Customer;
            this.Puppy = Puppy;
            this.Amount = Amount;
            this.PurchaseDate = PurchaseDate;
            this.DeliveryDate = DeliveryDate;
            this.Payment = Payment;
            this.Comment = Comment;
        }
    }
}
