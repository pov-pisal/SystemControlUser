using ConsoleTables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pov_Pisal
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string UnitPrice { get; set; }
        public string QtyInstock { get; set; }
        public static ArrayList arrayListProduct = new ArrayList();

        public void MenuItem()
        {
            Console.Clear();
        start:
            Console.WriteLine("--------------- Menu Item -----------------");
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Show Product");
            Console.WriteLine("3.Delete Product");
            Console.WriteLine("4.Update Product");
            Console.WriteLine("5.Search Product");
            Console.WriteLine("-------------------------------------------");
            int choose;
            Console.Write("Please choose menu item: ");
            choose = int.Parse(Console.ReadLine());
            Product product = new Product();
            switch (choose)
            {
                case 1:
                    product.Add();
                    break;
                case 2:
                    product.Show();
                    break;
                case 3:
                    product.DeleteById();
                    break;
                case 4:
                    product.UpdateById();
                    break;
                case 5:
                    product.Search();
                    break;
                default:
                    break;
            }
            goto start;
        }
        public void Add()
        {
            int n;
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
            Product product;
            for (int i = 0; i < n; i++)
            {
                product = new Product();
                Console.Write("Enter Id: ");
                product.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                product.Name = Console.ReadLine();
                Console.Write("Enter Barcode: ");
                product.Barcode = Console.ReadLine();
                Console.Write("Enter UnitPrice: ");
                product.UnitPrice = Console.ReadLine();
                Console.Write("Enter QtyInstock: ");
                product.QtyInstock = Console.ReadLine();
                arrayListProduct.Add(product);
                Console.Clear();
            }
        }
        public void Show()
        {
            Console.Clear();
            var table = new ConsoleTable("Id", "Name", "Barcode", "UnitPrice", "QtyInstock");
            for (int i = 0; i < arrayListProduct.Count; i++)
            {
                Product product1 = new Product();
                product1 = (Product)arrayListProduct[i];
                table.AddRow(product1.Id, product1.Name, product1.Barcode, product1.UnitPrice, product1.QtyInstock);
            }
            table.Write();
        }
        public void DeleteById()
        {
            Console.Write("Remive Id: ");
            this.Id = int.Parse(Console.ReadLine());
            for (int i = 0; i < arrayListProduct.Count; i++)
            {
                Product product = new Product();
                product = (Product)arrayListProduct[i];
                if (product.Id == this.Id)
                {
                    arrayListProduct.Remove(product);
                    Console.WriteLine("Delete Success!");
                }
                else
                {
                    Console.WriteLine("Id not Found!");
                }
            }
        }
        public void UpdateById()
        {
            Console.Write("Search By Id: ");
            this.Id = int.Parse(Console.ReadLine());
            for (int i = 0; i < arrayListProduct.Count; i++)
            {
                Product product = new Product();
                product = (Product)arrayListProduct[i];
                if (product.Id == this.Id)
                {
                    Product product1 = new Product();
                    Console.Write("Enter Name: ");
                    product1.Name = Console.ReadLine();
                    if (product1.Name != "")
                    {
                        product.Name = product1.Name;
                    }
                    Console.Write("Enter Barcode: ");
                    product1.Barcode = Console.ReadLine();
                    if (product1.Barcode != "")
                    {
                        product.Barcode = product1.Barcode;
                    }
                    Console.Write("Enter UnitPrice: ");
                    product1.UnitPrice = Console.ReadLine();
                    if (product1.UnitPrice != "")
                    {
                        product.UnitPrice = product1.UnitPrice;
                    }
                    Console.Write("Enter QtyInstock: ");
                    product1.QtyInstock = Console.ReadLine();
                    if (product1.QtyInstock != "")
                    {
                        product.QtyInstock = product1.QtyInstock;
                    }
                }
            }
        }
        public void Search()
        {
            Console.Write("Search By Id: ");
            int searchId = int.Parse(Console.ReadLine());
            bool found = false;
            foreach (Product product in arrayListProduct)
            {
                if (product.Id == searchId)
                {
                    Console.Clear();
                    var table = new ConsoleTable("Id", "Name", "Barcode", "UnitPrice", "QtyInstock");
                    table.AddRow(product.Id, product.Name, product.Barcode, product.UnitPrice, product.QtyInstock);
                    table.Write();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Products not found!");
            }
        }
    }
}
