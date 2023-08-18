using ConsoleTables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pov_Pisal
{
    internal class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tell { get; set; }
        public static ArrayList arrayListProduct = new ArrayList();

        public void MenuItem()
        {
            Console.Clear();
        start:
            Console.WriteLine("--------------- Menu Item -----------------");
            Console.WriteLine("1.Add Supplier");
            Console.WriteLine("2.Show Supplier");
            Console.WriteLine("3.Delete Supplier");
            Console.WriteLine("4.Update Supplier");
            Console.WriteLine("5.Search Supplier");
            Console.WriteLine("-------------------------------------------");
            int choose;
            Console.Write("Please choose menu item: ");
            choose = int.Parse(Console.ReadLine());
            Supplier supplier = new Supplier();
            switch (choose)
            {
                case 1:
                    supplier.Add();
                    break;
                case 2:
                    supplier.Show();
                    break;
                case 3:
                    supplier.DeleteById();
                    break;
                case 4:
                    supplier.UpdateById();
                    break;
                case 5:
                    supplier.Search();
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
            Supplier supplier;
            for (int i = 0; i < n; i++)
            {
                supplier = new Supplier();
                Console.Write("Enter Id: ");
                supplier.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                supplier.Name = Console.ReadLine();

                Console.Write("Enter Tell: ");
                supplier.Tell = Console.ReadLine();

                arrayListProduct.Add(supplier);

                Console.Clear();
            }
        }
        public void Show()
        {
            Console.Clear();
            var table = new ConsoleTable("Id", "Name", "Tell");
            for (int i = 0; i < arrayListProduct.Count; i++)
            {
                Supplier supplier1 = new Supplier();
                supplier1 = (Supplier)arrayListProduct[i];
                table.AddRow(supplier1.Id, supplier1.Name, supplier1.Tell);
            }
            table.Write();
        }
        public void DeleteById()
        {
            Console.Write("Remive Id: ");
            this.Id = int.Parse(Console.ReadLine());
            for (int i = 0; i < arrayListProduct.Count; i++)
            {
                Supplier supplier = new Supplier();
                supplier = (Supplier)arrayListProduct[i];
                if (supplier.Id == this.Id)
                {
                    arrayListProduct.Remove(supplier);
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
                Supplier supplier = new Supplier();
                supplier = (Supplier)arrayListProduct[i];
                if (supplier.Id == this.Id)
                {
                    Supplier supplier1 = new Supplier();
                    Console.Write("Enter Name: ");
                    supplier1.Name = Console.ReadLine();
                    if (supplier1.Name != "")
                    {
                        supplier.Name = supplier1.Name;
                    }
                    Console.Write("Enter Tell: ");
                    supplier1.Tell = Console.ReadLine();
                    if (supplier1.Tell != "")
                    {
                        supplier.Tell = supplier1.Tell;
                    }
                }
            }
        }
        public void Search()
        {
            Console.Write("Search By Id: ");
            int searchId = int.Parse(Console.ReadLine());
            bool found = false;
            foreach (Supplier supplier in arrayListProduct)
            {
                if (supplier.Id == searchId)
                {
                    Console.Clear();
                    var table = new ConsoleTable("Id", "Name", "Tell");
                    table.AddRow(supplier.Id, supplier.Name, supplier.Tell);
                    table.Write();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Supplier not found!");
            }
        }
    }
}
