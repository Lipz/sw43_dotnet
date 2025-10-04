using System;

namespace DOTNET
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string db = "users.db";
            Console.Clear();
            Console.WriteLine("======== Menu ==========");
            Console.WriteLine("1- Login ");
            Console.WriteLine("2- Register ");
            Console.WriteLine("3- Exit ");
            Console.WriteLine("=========================");
            Console.Write("Enter your option : ");
            string user_option = Console.ReadLine();

            switch (user_option)
            {
                case "1" : break;
                case "2" :
                    Console.Clear();    
                    Console.WriteLine("======== Register ==========");
                    Console.WriteLine("Username     : ");
                    Console.WriteLine("Email        : ");
                    Console.WriteLine("Password     : ");
                    Console.WriteLine("Re-Password  : ");
                    Console.WriteLine("============================");

                    Console.SetCursorPosition(15,1);
                    string username = Console.ReadLine();

                    Console.SetCursorPosition(15,2);
                    string email = Console.ReadLine();

                    Console.SetCursorPosition(15,3);
                    string password = Console.ReadLine();

                    Console.SetCursorPosition(15,4);
                    string repassword = Console.ReadLine();


                    // Write data to file.
                    string row = username + "," + email + "," + password;
                    using (StreamWriter writer = new StreamWriter(db, append: true))
                    {
                        writer.WriteLine(row);
                    }
                    Console.Clear();
                    Console.WriteLine("New user has been register");
                    break;
                case "3" :
                    Console.WriteLine("Bye!..");
                break;
            }

        }
            
    }
}