using System;
using System.Collections.Generic;

//To invent and implement registration and authorization of users.

namespace UserAuthorization
{
    class Program
    {
        static void Main(string[] args)
        {

            List<User> users = new List<User>();

            Console.WriteLine("To exit the program type: \"end\", or any other key to continue");
            string end = Console.ReadLine();
            while (end != "end")
            {
                Console.Write("Good afternoon. Are you registered? Press y / n: ");
                string character = Console.ReadLine();

                if ((character != "y") && (character != "n"))
                {
                    Console.WriteLine("Invalid character");
                }
                else
                {
                    if (character == "y")
                    {
                        Console.WriteLine("Authorization...");
                        Console.Write("Enter your login: ");
                        string login = Console.ReadLine();

                        Console.Write("Enter your password: ");
                        string pass = Console.ReadLine();

                        Console.WriteLine(new User().Authorization(login, pass, users));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Registration...");
                        Console.Write("Enter your name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter your login: ");
                        string login = Console.ReadLine();

                        Console.Write("Enter your password: ");
                        string pass = Console.ReadLine();

                        users.Add(new User().Registration(name, login, pass));
                    }
                }
                Console.WriteLine("To exit the program type: \"end\", or any other key to continue");
                end = Console.ReadLine();
            }
        }


        class User
        {
            string name;
            string login;
            string pass;
            string check = "Invalid login or password";

            public string Authorization(string login, string pass, List<User> users)
            {
                foreach (User user in users)
                {

                    if (user.login == login && user.pass == pass)
                    {
                        Console.WriteLine($"User name: {user.name}");
                        check = "You are successfully authorized, Yes!!!";
                    }
                }
                return check;
            }

            public User Registration(string name, string login, string pass)
            {
                User user = new User();
                user.name = name;
                user.login = login;
                user.pass = pass;
                return user;
            }

        }

    }
}

