﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double KTLO_TO_MILES = 1.6;
            double milesEntry = 5;
            double kilo;

            kilo = KTLO_TO_MILES * milesEntry;
            Console.WriteLine("the number of miles entered was {0}, " +
                "and that equals {1} kilometers.", milesEntry, kilo);

            displayEnterActiveConversion();

        }
      public static void displayEnterActiveConversion() {
        const double KTLO_TO_MILES = 1.6;
        double milesEntry = 5;
        double kilo;
        String milesEntryString;

        Console.WriteLine("just enter some miles now!!! >>>>");
            milesEntryString = Console.ReadLine();
            milesEntry = Convert.ToDouble(milesEntryString);

            kilo = KTLO_TO_MILES * milesEntry;
            Console.WriteLine("the number of miles entered was {0}," +
                "and that equals {1} kilometers.", milesEntry, kilo);
    }
}
