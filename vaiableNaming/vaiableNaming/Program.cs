using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaiableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 15;
            int resultAdd;
            int resultMinus;
            int resultDivide;
            int resultMultiply;
            int resultModulus;

            resultAdd = num1 + num2;
            resultMinus = num2 - num1;
            resultDivide = num2 / num1;
            resultMultiply = num2 * num1;
            resultModulus = num2 % num1;

           
            Console.WriteLine("the result of ${0} + ${1} = ${2}", num1, num2, resultAdd);
            Console.WriteLine("the result of ${0} - ${2} = ${1}", num2, num1, resultMinus);
            Console.WriteLine("the result of ${0} / ${2} = ${1}", num2, num1, resultDivide);
            Console.WriteLine("the result of ${0} * ${2} = ${1}", num2, num1, resultMultiply);
            Console.WriteLine("the result of ${0} % ${2} = ${1}", num2, num1, resultModulus);
        }
    }
}
