using Assignment_Hospital.classes;
using System;

namespace Assignment_Hospital
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Auth auth = new Auth();

            string usr = auth.LogIn("test@test.com", "test");

            if (usr == "error") { Console.WriteLine("Invalid Details"); return; }

            Console.WriteLine(auth.Id);
            Console.WriteLine(auth.Name);
            Console.WriteLine(auth.Email);
            Console.WriteLine("Groups: \n");
            foreach (string s in auth.Groups) { Console.WriteLine(s); }
        }
    }
}
