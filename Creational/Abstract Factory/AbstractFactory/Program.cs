using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new WordDocument(1);
            d1.Display();
            d1.Print();

            var d2 = new NewWordDocument(new HighResolutionDocumentFactory());
            d2.Display();
            d2.Print();

            Console.ReadKey();
        }
    }
}
