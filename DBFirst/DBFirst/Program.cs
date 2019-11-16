using System;
using System.Linq;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User user1 = new User() { Name = "Karlen", Age = 22 };
            User user2 = new User() { Name = "Lux", Age = 20 };

            Add(user1, user2);
            PrintData();

            Delete(user1);
            PrintData();
            Console.ReadKey();
        }

        private static void Add(params User[] users)
        {
            using (TestDBContext context = new TestDBContext())
            {
                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }

        private static void Delete(User user)
        {
            if (user != null)
            {
                using (TestDBContext context = new TestDBContext())
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
        }

        private static void PrintData()
        {
            using (TestDBContext context = new TestDBContext())
            {
                var list = context.Users.ToList();

                foreach (var item in list)
                {
                    Console.WriteLine("{0} - {1} - {2}", item.Id, item.Name, item.Age);
                }
                Console.WriteLine(new string('-',15));
            }
        }
    }
}
