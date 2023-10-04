using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int alpha, digit, speChar, i, length;
            alpha = digit = speChar = i = 0;
            Console.WriteLine("Enter the String : ");
            str = Console.ReadLine();
            length = str.Length;
            while(i< length) 
            {
                if ((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
                {
                    alpha++;
                }
                else if (str[i]>='0' && str[i]<='9')
                {
                    digit++;
                }
                else
                {
                    speChar++;
                }  
                i++;
            }
            Console.WriteLine("Alphabets available in given string : {0}", alpha);
            Console.WriteLine("Digits available in given string : {0}", digit);
            Console.WriteLine("Special character available in given string : {0}", speChar);
            Console.ReadLine();
        }
    }
}
