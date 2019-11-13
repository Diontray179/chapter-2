using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            String color;
            String wordEst;
            String bodyPartPlural;
            String anAmimal;
            String noun;
            String pluralNoun;
            int a;
            int b;
            int c;

            Console.WriteLine("what is your favorite color >>> " );
            color = Console.ReadLine();

            Console.WriteLine("Enter a word ending in wordEst >>> ");
            wordEst = Console.ReadLine();

            Console.WriteLine("Enter a body part Plural >>> ");
            bodyPartPlural = Console.ReadLine();

            Console.WriteLine("Enter a Amimal >>> ");
            anAmimal = Console.ReadLine();

            Console.WriteLine("Enter a noun >>> ");
            noun = Console.ReadLine();

            Console.WriteLine("Enter a plural Noun >>> ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Enter a Number >>> ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Number that is bigger than the number you put first >>> ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a - b;


            Console.WriteLine("the {0} uragon is the" +
                "{1} Dragon of all. it has {2} {3}, and a {4} shaped like a {5}, although" +
                " it will feast on nearly anything" ,
                color, wordEst, c, bodyPartPlural, anAmimal, noun, pluralNoun);
        }
    }
}
