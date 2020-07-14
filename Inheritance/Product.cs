using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Product
    {
        int productID;
        string model;
        string brand; 
        int price;

        internal void SetProductData(int productID, string model, string brand, int price)
        {
            this.productID = productID;
            this.model = model;
            this.brand = brand;
            this.price = price;
        }

        internal void Display()
        {
            Console.WriteLine($"product ID: {productID} Model: {model} Brand: {brand} Price: {price}");
        }

    }
}
