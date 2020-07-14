
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigirator r1 = new Refrigirator();
            r1.SetRefrigiratorData(101, "RT23", "Samsung", 40000, 30, "Silver", "Metal");
            r1.Display();
        }
    }
}
