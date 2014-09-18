namespace AbstractFactory
{
    using System;

    public class LowResolutionPrint:IPrint
    {
        public void Print()
        {
            Console.WriteLine("low resolution print");
        } 
    }
}