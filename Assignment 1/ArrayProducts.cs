using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ArrayProducts
    {
        int productid;
        public int ProductId
        { get
            {
                return productid;

            }
            set
            {
                productid = value;
            }
        }

        string productname;
        public string ProductName {
            get
            { 
                return productname; 
            }
            set
            {
                productname = value;
            }
        }

        int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        string unitofmeasurement;
        public string UnitOfMeasurement {
            get
            {
                return unitofmeasurement;
            }
            set
            {
                unitofmeasurement = value;
            }
        }

        int qty;
        public int Qty {
            get
            {
                return qty;
            }
            set
            {
                qty = value;
            }
        }

        static void Main(string[] args)
        {
            ArrayProducts[] products = new ArrayProducts[5];
            products[0] = new ArrayProducts();
            products[0].ProductId = 1;
            products[0].ProductName = "Laptop";
            products[0].Price = 999;
            products[0].UnitOfMeasurement = "Each";
            products[0].Qty = 10;

            products[1] = new ArrayProducts();
            products[1].ProductId = 2;
            products[1].ProductName = "Laptop1";
            products[1].Price = 9999;
            products[1].UnitOfMeasurement = "Each";
            products[1].Qty = 20;

            products[2] = new ArrayProducts();
            products[2].ProductId = 3;
            products[2].ProductName = "Laptop2";
            products[2].Price = 99;
            products[2].UnitOfMeasurement = "Each";
            products[2].Qty = 310;

            products[3] = new ArrayProducts();
            products[3].ProductId = 4;
            products[3].ProductName = "Laptop3";
            products[3].Price = 100;
            products[3].UnitOfMeasurement = "Each";
            products[3].Qty = 40;

            products[4] = new ArrayProducts();
            products[4].ProductId = 5;
            products[4].ProductName = "Laptop4";
            products[4].Price = 200;
            products[4].UnitOfMeasurement = "Each";
            products[4].Qty = 50;

            foreach (var item in products)
            {
   
                    Console.WriteLine(item.ProductId);
                    Console.WriteLine(item.ProductName);
                    Console.WriteLine(item.Price);
                    Console.WriteLine(item.UnitOfMeasurement);
                    Console.WriteLine(item.Qty);
                    Console.ReadLine();
            }
        }
    }
}

        






