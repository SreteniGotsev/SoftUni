using System;
using System.Diagnostics.Tracing;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            bool length = PassLength(input);
            bool digits = PassContentDig(input);
            bool content = PassContent(input);
            if (length && digits && content)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!length)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!content)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!digits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        static bool PassLength(string text)
        {
            bool isLength = false;
            if (text.Length >= 6 && text.Length <= 10)
            {
                isLength = true;
            }
            
            return isLength;
        }

        static bool PassContentDig(string text)
        {
            bool isEnoughDigits = false;
            int counter = 0;
            char[] nums = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                char t = nums[i];
                if (t == '1' || t == '2' || t == '3' 
                 || t == '4' || t == '5' || t == '6' 
                 || t == '7' || t == '8' || t == '9' || t == '0')
                {
                    counter++;
                }
            }
           
            if (counter >= 2)
            {
                isEnoughDigits = true;
            }
            
            return isEnoughDigits;
        }
        static bool PassContent(string text)
        {
            bool isOnly = false;
            char[] nums = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                char t = nums[i];
                if (t == '1'|| t == '2' || t == '3' || t == '4' || t == '5' || t == '6' || t == '7' || t == '8' || t == '9' || t == '0'
                 || t == 'a'|| t == 'b' || t == 'c' || t == 'd' || t == 'e' || t == 'f' || t == 'g' || t == 'h' || t == 'i' || t == 'j'
                 || t == 'k'|| t == 'l' || t == 'm' || t == 'n' || t == 'o' || t == 'p' || t == 'q' || t == 'r' || t == 's'
                 || t == 't'|| t == 'u' || t == 'v' || t == 'w' || t == 'x' || t == 'y' || t == 'z')
                {
                    isOnly = true;
                }
                else
                {
                    isOnly = false;
                    break;
                }
            }       
             return isOnly;
        }
    }
}
