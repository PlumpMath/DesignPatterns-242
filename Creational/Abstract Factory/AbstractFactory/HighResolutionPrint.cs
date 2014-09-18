namespace AbstractFactory
{
    using System;

    public class HighResolutionPrint:IPrint
    {
        public void Print()
        {
            Console.WriteLine("hign resolution print");
        } 
    }
}