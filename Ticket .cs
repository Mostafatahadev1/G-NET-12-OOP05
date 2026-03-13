using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP05
{
    public abstract class Ticket : IPrintable, IBookable, IClonable
    {
        private static int counter = 0;

        public int TicketId { get; }

        public string MovieName { get; set; }

        protected decimal Price;

        protected bool isBooked = false;

        public decimal PriceAfterTax => Price * 1.14m;

        public Ticket(string movieName, decimal price)
        {
            counter++;
            TicketId = counter;
            MovieName = movieName;
            Price = price;
        }

        public bool Book()
        {
            if (isBooked)
                return false;

            isBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!isBooked)
                return false;

            isBooked = false;
            return true;
        }

        public abstract void Print();

        public abstract object Clone();
    }
}
