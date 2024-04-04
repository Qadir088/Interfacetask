using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal class User : IAccount
    {
        public string FullName;
        public string Email;
        public string Password;
        
         public User(string fullname,string email) 
        {
            FullName = fullname;
            Email = email;
        }
        public bool PasswordChecker(string password)
        {
            bool isValidPassword = false;
            do
            {
                Console.WriteLine("Enter your passowrd");
                password = Console.ReadLine();
                if (password.Length < 8)
                {
                    Console.WriteLine("Password must not be less than 8 characters");
                    continue;
                }

                bool UpCase = false;
                bool loCase = false;
                bool hasNum = false;

                foreach(char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        UpCase = true;
                    }
                    if (char.IsLower(c))
                    {
                        loCase = true;
                    }
                    if (char.IsDigit(c))
                    {
                        hasNum = true;
                    }
                }

                if (!UpCase)
                {
                    Console.WriteLine("must be at least 1 letter uppercase");
                    continue;
                }
                if (!loCase)
                {
                    Console.WriteLine("must be at least 1 letter lowercase");
                    continue;
                }
                if (!hasNum)
                {
                    Console.WriteLine("must be at least 1 digit");
                    continue;
                }
            } while(!isValidPassword);
            Console.WriteLine("Successful");
            return true;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Fullname" +{FullName});
            Console.WriteLine("Email" +{Email});
        }
        interface IAccount
        {
            public bool PasswordChecker(string[] passowrd);
            public void ShowInfo();
        }
    }
}
