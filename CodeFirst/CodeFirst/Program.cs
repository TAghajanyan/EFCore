using System;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (AppContext context = new AppContext())
            {
                context.Users.AddRange(new User() { Name = "John", Age = 19 }, new User() { Name = "Alice", Age = 18 });
                context.SaveChanges();
            }
        }
    }
}
