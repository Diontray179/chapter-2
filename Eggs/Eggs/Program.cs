using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int dozedEggs = 12;
            int numEggs = 127; //num of eggs entered
            int cartonOfEggs;
            int eggsRemaining;

            Console.WriteLine("how many eggs are there ?");
            numEggs = Convert.ToInt32(Console.ReadLine());

            cartonOfEggs = numEggs / dozedEggs;
            eggsRemaining = numEggs % dozedEggs;

            Console.WriteLine("the number of eggs collected was {0} and, we have {1} cartons of eggs and," +
                "{2} eggs remainig", numEggs, cartonOfEggs, eggsRemaining);
      

        }
    }
}
