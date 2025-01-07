using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoint_TwoToFour.Services.Mini2
{
    public class AddingNumbers : IAddingNumbers
    {
        public string AddTwoNumbers (int num1, int num2)
        {
            return num1 + " + " + num2 + " = " + (num1 + num2) + ".";
        }
    }
}