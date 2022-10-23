using Microsoft.EntityFrameworkCore;
using mtmwhw;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            Console.WriteLine("Input Name:");
            string lexa = Console.ReadLine();
            Console.WriteLine("Input Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            User Lexa = new User { Name = lexa, Age = age };
            db.Users.Add(Lexa);
            db.SaveChanges();
            var users = db.Users.ToList();
            Console.WriteLine("Object Added");
            Console.WriteLine("Список объектов:");
            foreach (User u in users)
            {
                Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
            }

        }
    }
}