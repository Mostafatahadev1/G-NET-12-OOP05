using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP05
{
     class VIPTicket : Ticket
    {
        public bool LoungeAccess;
        public decimal ServiceFee;

        public VIPTicket(string movie, decimal price, bool lounge, decimal fee)
            : base(movie, price)
        {
            LoungeAccess = lounge;
            ServiceFee = fee;
        }

        public override void Print()
        {
            Console.WriteLine(
            $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(isBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new VIPTicket(MovieName, Price, LoungeAccess, ServiceFee);
        }
    }
}
