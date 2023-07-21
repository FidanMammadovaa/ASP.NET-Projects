using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string input = "1.0958";
        double number;

        if (Double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out number))
        {
            string formattedNumber = number.ToString("R", CultureInfo.InvariantCulture);
            Console.WriteLine(formattedNumber);
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}
