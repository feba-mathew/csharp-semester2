using Homework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Models.User> users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });
            
            // 1. Query all users whose password is "hello"
            IEnumerable<Models.User> query = users.Where(user => user.Password == "hello");
            Console.WriteLine("Users whose password is hello are");
            foreach (Models.User user in query)
            {
                Console.WriteLine(user.Name);
            }

            // 2. Remove users whose password is lowercase versions of their name
            var query2 = users.Where(user => user.Password == user.Name.ToLower()).ToList();
            int usersRemoved = users.RemoveAll(user => user.Password == user.Name.ToLower());
            Console.WriteLine("\nRemoved " + usersRemoved + " users whose password is lowercase version of their name");

            // 3. Delete the first User that has the password "hello"
            IEnumerable<Models.User> userNames = users.Where(user => user.Password == "hello");
            string nameToRemove = userNames.First().Name;
            var query3 = users.Remove(userNames.First());
            Console.WriteLine("\nRemoved " + nameToRemove + ", the first user who has the password 'hello'");

            // 4. Display to the console the remaining users with their Name and Password
            var query4 = users.Select(user => user);
            Console.WriteLine("\nRemaining users are:");
            foreach (var obj in query4)
            {
                Console.WriteLine("Name: {0}, Password: {1}", obj.Name, obj.Password);
            }
        }
    }
}
