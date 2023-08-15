using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pov_Pisal
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("--------------- Menu System -----------------");
            Console.WriteLine("1.User");
            Console.WriteLine("2.Product");
            Console.WriteLine("3.Supplier");
            Console.WriteLine("-------------------------------------------");
            int choose;
            Console.Write("Please choose menu system: ");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {

                case 1:
                    User user = new User();
                    user.MenuItem();
                    break;
                case 2:
                    Product product = new Product();
                    product.MenuItem();
                    break;
                case 3:
                    Supplier supplier = new Supplier();
                    supplier.MenuItem();
                    break;
                default:
                    break;
            }
            goto start;

        }
    }
}
