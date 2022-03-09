using System;
using System.Linq;

namespace CharInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharConvert(firstChar, secondChar);
            
            ;
            //foreach (var item in arr)
            //{
            //    Console.Write(string.Join(" ", arr));
            //}


        }

        static void CharConvert(char text, char text2)
        {
            int first = ((int)text);
            int last = ((int)text2);
            
            if (first < last)
            {
                for (int i = first + 1; i < last; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = last + 1; i < first; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
          
        }
    }
}
