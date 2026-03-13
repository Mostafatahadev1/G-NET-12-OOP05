using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP05
{
    static class BookingHelper
    {

        public static void PrintAll(IPrintable[] items)
        {
            foreach (var item in items)
            {
                item.Print();
            }
        }
    }
}
