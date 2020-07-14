using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Refrigirator : Product
    {
        int capacity;
        string colour;
        string material;

        internal void SetRefrigiratorData(
            int productID, string model, string brand, int price, 
            int capacity, string colour, string material)
        {
                base.SetProductData(productID, model, brand, price);
                this.capacity = capacity;
                this.colour = colour;
                this.material = material;
        }

        internal void Display()
        {
            base.Display();
            Console.WriteLine($"Capacity: {capacity} Color: {colour} Material: {material}");
        }
    }
}
