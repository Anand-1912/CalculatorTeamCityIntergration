using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTeamCityIntergration1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine($"The Sum of 4 and 5 is {calculator.Add(4, 5)}");
            Console.ReadLine();
        }
    }
}
