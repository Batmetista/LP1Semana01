using System;
string test1 = "'\u00A9' This is a symbol."
string test2 = "'\u000A' This is another symbol."
string conc = "Uma "+ "string " + "concatenada";
string inter = $"{x} mais {y} e' igual a {x + y}";
namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(conc);
            Console.WriteLine(inter);
            Console.WriteLine(xx);
            Console.WriteLine(ii);
        }
    }
}
