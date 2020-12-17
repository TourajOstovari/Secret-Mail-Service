using System;
using System.Collections.Generic;
using System.Text;

namespace SecretMailService
{
    static class Captcha
    {

        public static dynamic Generator()
        {
        Check_Again:
            char[] txt_cap = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'a', 'b', 'c', 'd', 'e', 'f' };
            string cap = "";
            Random random = new Random();
            for (int i = 0; i <= 3; i++)
            {
                int num = random.Next(0, 15);
                cap += txt_cap[num];
            }
            return cap;
        }
        public static dynamic Validator()
        {
            string temp_cap = "";
            string temp_cap_ = "";
            do
            {
                temp_cap = Captcha.Generator();
                Console.WriteLine("Enter the captcha >>>> [ {0} ] <<<<:", temp_cap);
                temp_cap_ = Console.ReadLine();
                if (temp_cap.ToLower() == temp_cap_.ToLower())
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("OK");
                    return true;
                }
            } while (temp_cap.ToLower() != temp_cap_.ToLower());
            return false;
        }
    }
}
