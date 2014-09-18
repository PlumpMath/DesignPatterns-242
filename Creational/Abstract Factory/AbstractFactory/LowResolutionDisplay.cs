namespace AbstractFactory
{
    using System;

    public class LowResolutionDisplay:IDisplay
    {
        public void Display()
        {
            Console.WriteLine("low resolution display");
        }
    }
}