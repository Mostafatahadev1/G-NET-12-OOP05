using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP05
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D;

        public IMAXTicket(string movie, decimal price, bool is3D)
            : base(movie, price)
        {
            Is3D = is3D;
        }

        public override void Print()
        {
            Console.WriteLine(
            $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(isBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new IMAXTicket(MovieName, Price, Is3D);
        }
    }
}
