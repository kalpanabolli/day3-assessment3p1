using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment3p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine("Parsed Number using intTryParse is :\t" + result);
                }
                else
                {
                    Console.WriteLine("Faile to Parse");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }
            try
            {
                string convertString;
                Console.WriteLine("Enter the String");
                convertString = Console.ReadLine();
                double Value = Convert.ToDouble(convertString);
                Console.WriteLine("Convert successful. Converted double value: " + Value);

            }
            catch (FormatException)
            {
                Console.WriteLine("Convert failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Convert failed. Input value is too large or too small.");
            }

            try
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();

                decimal Value = Convert.ToDecimal(input);
                Console.WriteLine("Parse successful. Converted decimal value: " + Value);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Parse failed. Input value is too large or too small.");

            }
            Console.ReadKey();
        }
    }
}