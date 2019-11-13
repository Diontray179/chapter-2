using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaise
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PREDICTED_RAISES = 1.04;
            double employeesalary1;
            double employeesalary2;
            double employeesalary3;

            Console.WriteLine("what is employee 1's saraly this year >>>");
            employeesalary1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what is employee 2's saraly this year >>>");
            employeesalary2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what is employee 3's saraly this year >>>");
            employeesalary3 = Convert.ToDouble(Console.ReadLine());

            employeesalary1 = employeesalary1 * PREDICTED_RAISES;
            employeesalary2 = employeesalary2 * PREDICTED_RAISES;
            employeesalary3 = employeesalary3 * PREDICTED_RAISES;


            Console.WriteLine("employee 1 saraly is {0}", employeesalary1);
            Console.WriteLine("employee 2 saraly is {0}", employeesalary2);
            Console.WriteLine("employee 3 saraly is {0}", employeesalary3);



        }
    }
}
