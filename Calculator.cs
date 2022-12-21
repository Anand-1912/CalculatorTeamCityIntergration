using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTeamCityIntergration1
{
    public class Calculator
    {
        public int operand1 { get; set; }
        public int operand2 { get; set; }

        public int Add(int op1, int op2)
        {
            return op1 + op2;
        }
        public int Sub(int op1, int op2)
        {
            return op1 - op2;
        }
        public int Multiply(int op1, int op2)
        {
            return op1 * op2;
           
        }
        public int Divide(int op1, int op2)
        {
            return op1 / op2;

        }

    }
}
