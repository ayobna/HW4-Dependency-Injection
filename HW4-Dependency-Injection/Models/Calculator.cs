using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW4_Dependency_Injection.Models
{
    public class Calculator : ICalculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
