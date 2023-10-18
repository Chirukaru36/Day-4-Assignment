using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Product
    {
		private  int product_id;

		public int ProductId
		{
			get { return product_id; }
			set { product_id = value; }
		}
		private String product_name;

		public string ProductName

		{
			get { return product_name; }
			set { product_name = value; }
		}
		private  int Price;

		public  int ProductPrice
		{
			get { return Price; }
			set { Price = value; }
		}

		private float Unitofmeasurement;

		public float UnitOfMeasurement

		{
			get { return Unitofmeasurement; }
			set { Unitofmeasurement = value; }
		}

		private int qty;

		public int Quantity
		{
			get { return qty; }
			set { qty = value; }
		}

		static void Main(string[] args)
		{
			Product P = new Product();
			P.ProductId = 23;
			P.ProductName = "Gadget";
			P.ProductPrice = 100;
			P.Unitofmeasurement = 50.44f;
			P.qty = 10000;
			Console.WriteLine($"product id = {P.ProductId}");
            Console.WriteLine($"product name = {P.ProductName}");
			Console.WriteLine($"prduct price = {P.ProductPrice}");
			Console.WriteLine($"product uinitofmeasurement = {P.Unitofmeasurement}");
			Console.WriteLine($"quantity = {P.qty}");
			Console.WriteLine("*************************");

            Product P1 = new Product();
            P1.ProductId = 2;
            P1.ProductName = "Widget";
            P1.ProductPrice = 200;
            P1.Unitofmeasurement = 100.00f;
            P1.qty = 20000;
            Console.WriteLine($"product id = {P1.ProductId}");
            Console.WriteLine($"product name = {P1.ProductName}");
            Console.WriteLine($"prduct price = {P1.ProductPrice}");
            Console.WriteLine($"product uinitofmeasurement = {P1.Unitofmeasurement}");
            Console.WriteLine($"quantity = {P1.qty}");
            Console.WriteLine("*************************");

            Product P2 = new Product();
            P2.ProductId = 3;
            P2.ProductName = "Tool";
            P2.ProductPrice = 300;
            P2.Unitofmeasurement = 60.75f;
            P2.qty = 30000;
            Console.WriteLine($"product id = {P2.ProductId}");
            Console.WriteLine($"product name = {P2.ProductName}");
            Console.WriteLine($"prduct price = {P2.ProductPrice}");
            Console.WriteLine($"product uinitofmeasurement = {P2.Unitofmeasurement}");
            Console.WriteLine($"quantity = {P2.qty}");
            Console.WriteLine("*************************");

            Product P3 = new Product();
            P3.ProductId = 4;
            P3.ProductName = "Gadget2";
            P3.ProductPrice = 400;
            P3.Unitofmeasurement = 75.44f;
            P3.qty = 40000;
            Console.WriteLine($"product id = {P3.ProductId}");
            Console.WriteLine($"product name = {P3.ProductName}");
            Console.WriteLine($"prduct price = {P3.ProductPrice}");
            Console.WriteLine($"product uinitofmeasurement = {P3.Unitofmeasurement}");
            Console.WriteLine($"quantity = {P3.qty}");
            Console.WriteLine("*************************");

            Product P4 = new Product();
            P4.ProductId = 5;
            P4.ProductName = "Accessory";
            P4.ProductPrice = 500;
            P4.Unitofmeasurement = 555.55f;
            P4.qty = 50000;
            Console.WriteLine($"product id = {P4.ProductId}");
            Console.WriteLine($"product name = {P4.ProductName}");
            Console.WriteLine($"prduct price = {P4.ProductPrice}");
            Console.WriteLine($"product uinitofmeasurement = {P4.Unitofmeasurement}");
            Console.WriteLine($"quantity = {P4.qty}");
            Console.WriteLine("*************************");
            Console.ReadLine();


        }




	}
}
