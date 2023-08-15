using ConsoleTables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pov_Pisal
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public string Tell { get; set; }
        public string Address { get; set; }
        public static ArrayList arrayListUser = new ArrayList();

        public void MenuItem()
        {
            Console.Clear();
        start:
            Console.WriteLine("--------------- Menu Item -----------------");
            Console.WriteLine("1.Add User");
            Console.WriteLine("2.Show User");
            Console.WriteLine("3.Delete User");
            Console.WriteLine("4.Update User");
            Console.WriteLine("5.Search User");
            Console.WriteLine("------------------------------------------");
            int choose;
            Console.Write("Please choose menu item: ");
            choose = int.Parse(Console.ReadLine());
            User user = new User();
            switch (choose)
            {
                case 1:
                    user.Add();
                    break;
                case 2:
                    user.Show();
                    break;
                case 3:
                    user.DeleteById();
                    break;
                case 4:
                    user.UpdateById();
                    break;
                case 5:
                    user.Search();
                    break;
                default:
                    break;
            }
            goto start;
        }
        public void Add()
        {
            Console.Clear();
            int n;
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
            User user;
            for (int i = 0; i < n; i++)
            {
                user = new User();
                Console.Write("Enter Id: ");
                user.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                user.Name = Console.ReadLine();
                Console.Write("Enter Gender: ");
                user.Gender = Console.ReadLine();
                Console.Write("Enter Passworld: ");
                user.Password = Console.ReadLine();
                Console.Write("Enter Tell: ");
                user.Tell = Console.ReadLine();
                Console.Write("Enter Address: ");
                user.Address = Console.ReadLine();
                arrayListUser.Add(user);
                Console.Clear();
            }
        }
        public void Show()
        {
            Console.Clear();
            var table = new ConsoleTable("Id", "Name", "Gender", "Password", "Tell", "Address");
            for (int i = 0; i < arrayListUser.Count; i++)
            {
                User user = new User();
                user = (User)arrayListUser[i];
                table.AddRow(user.Id, user.Name, user.Gender, user.Password, user.Tell, user.Address);
            }
            table.Write();
        }
        public void DeleteById()
        {
            Console.Write("Remive Id: ");
            this.Id = int.Parse(Console.ReadLine());
            for (int i = 0; i < arrayListUser.Count; i++)
            {
                User user = new User();
                user = (User)arrayListUser[i];
                if (user.Id == this.Id)
                {
                    arrayListUser.Remove(user);
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
            for (int i = 0; i < arrayListUser.Count; i++)
            {
                User user = new User();
                user = (User)arrayListUser[i];
                if (user.Id == this.Id)
                {
                    User user1 = new User();
                    Console.Write("Enter Name: ");
                    user.Name = Console.ReadLine();
                    if (user.Name != "")
                    {
                        user.Name = user1.Name;
                    }
                    Console.Write("Enter Gender: ");
                    user1.Gender = Console.ReadLine();
                    if (user1.Gender != "")
                    {
                        user.Gender = user1.Gender;
                    }
                    Console.Write("Enter Password: ");
                    user1.Password = Console.ReadLine();
                    if (user1.Password != "")
                    {
                        user.Password = user1.Password;
                    }
                    Console.Write("Enter Tell: ");
                    user1.Tell = Console.ReadLine();
                    if (user1.Tell != "")
                    {
                        user.Tell = user1.Tell;
                    }
                    Console.Write("Enter Address: ");
                    user1.Address = Console.ReadLine();
                    if (user1.Address != "")
                    {
                        user.Address = user1.Address;
                    }
                }
            }
        }
        public void Search()
        {
            Console.Write("Search By Id: ");
            int searchId = int.Parse(Console.ReadLine());
            bool found = false;
            foreach (User user in arrayListUser)
            {
                if (user.Id == searchId)
                {
                    Console.Clear();
                    var table = new ConsoleTable("Id", "Last Name", "First Name", "Gender", "Address");
                    table.AddRow(user.Id, user.Name, user.Gender, user.Password, user.Tell, user.Address);
                    table.Write();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Student not found!");
            }
        }
    }
}
