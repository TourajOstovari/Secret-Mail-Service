using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using Console = Beautiful.Console;
namespace SecretMailService
{
    class Program
    {
        [MTAThread()]
        static void Main(string[] args)
        {
            
            //Spectre.Console.
            
            Console.Title = "... Welcome to Secret Mail Service | Free World ...";
            Console.ForegroundColor = Color.Green;
            Console.WriteLine("Hello I am Tornet656 | Mr. Touraj Ostovari | Developed in 2020 \n It is a free world without rules and seprate private network for exchanging emails \n AND Strong Encryption with Strong Password Generator...\n NOTHING WOULD BE RECORDED FROM OUR SIDE", Color.FromArgb(26, 188, 156, 1));
            Console.WriteLine("* For Sign up enter number (1) \n* For Sign in enter number (2) \n* anything else means exit.", Color.FromArgb(236, 240, 241));
            Console.WriteLine("Which Option?");
            try
            {
                SignUp sign = new SignUp();
                Int64 item = int.Parse(Console.ReadLine());
                switch (item)
                {
                    // Sing up
                    case 1:
                        if (new SignUp().Signup() == true) goto User_Panel;
                        break;

                    // Sing in
                    case 2:
                        if (new SignUp().Signin() == true) goto User_Panel;
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        User_Panel:
            Console.Clear();
            Console.Title = "... Dear Welcome To Dark Mail Service ...";
            Console.ForegroundColor = Color.Yellow;
            Console.WriteLine("** After checking NEW e-mail(s) or with trying to decrypt them would be removed from our server's DataBase\n * For Checking NEW mails number (1)\n * For Chaning E-mail Info Press number (2)\n * Check for new updates\nWhich Option??");
            try
            {
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        // Fetch Info
                    break;
                    case 2:
                        // Generate new Info
                    break;
                    case 3:
                        SignUp update = new SignUp();
                        //if(update.version.CompareTo() > 0)
                        {

                        }
                        // Check new update
                    break;
                    default:
                        goto User_Panel;
                        break;

                }
            }
            catch (Exception)
            {

                Environment.Exit(0);
            }
            Console.ReadLine();

        }
    }

}
