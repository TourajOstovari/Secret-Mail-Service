using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using Console = Beautiful.Console;
using System.Drawing;
namespace SecretMailService
{
    
    interface ISign
    {
         bool Signup();
         bool Signin();

    }
    internal class SignUp:ISign
    {
        public string version { get; set; } = "1.0";
        private string email;
        private string password;

        public bool Signin()
        {
            Console.Clear();
            Console.ForegroundColor = Color.DarkRed;
            Console.Title = "S I G N - I N - Without personal info needed ...";
            Console.WriteLine("Enter your email:");
            string email_ = Console.ReadLine();
            Console.WriteLine("Enter email's password:");
            string pass_ = Console.ReadLine();

            if (Captcha.Validator() == true)
            {
                // when captcha was valid, login to user if validate the email address and password ....
                return true;
            }

            return false;
        }

        public bool Signup()
        {
            Console.Clear();
            Console.ForegroundColor = Color.Yellow;
            Console.Title = "S I G N - U P - Without personal info needed ...";
            Console.WriteLine("Enter new email:");
            Console.WriteLine("Valid or non-valid is not matter, this would your email address inside private network", ConsoleColor.Yellow);
            string email_ = Console.ReadLine();
            Console.WriteLine("Enter password");
            string pass_ = Console.ReadLine();
            if (Captcha.Validator() == true)
            {
                // when was captcha valid, register email and password in db by WCF Service...
                return true;
            }

            return false;
        }
    }
}
