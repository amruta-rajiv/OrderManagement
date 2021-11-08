using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    public class Helpers
    {
        public static string GetStringInput()
        {
            string input = Console.ReadLine();

            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter valid details.");
                input = Console.ReadLine();
            }

            return input;
        }

        public static int GetNumberInput()
        {
            int number;
            string input = Console.ReadLine();

            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("Please enter a valid number.");
                input = Console.ReadLine();
            }

            return number;
        }

        public static DateTime GetDateInput()
        {
            DateTime input;
            string strInput = Console.ReadLine();

            while (!DateTime.TryParse(strInput, out input))
            {
                Console.WriteLine("Please enter a valid date.");
                strInput = Console.ReadLine();
            }
            return input;
        }
    }
}
