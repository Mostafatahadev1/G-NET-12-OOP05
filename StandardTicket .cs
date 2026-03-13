using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP05
{
    class StandardTicket : Ticket
    {
        public Seat SeatNumber;

        public StandardTicket(string movie, Seat seat, decimal price)
            : base(movie, price)
        {
            SeatNumber = seat;
        }

        public override void Print()
        {
            Console.WriteLine(
            $"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(isBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new StandardTicket(MovieName, SeatNumber, Price);
        }

    }
}
