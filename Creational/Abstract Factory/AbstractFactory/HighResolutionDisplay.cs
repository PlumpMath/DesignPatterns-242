namespace AbstractFactory
{
    using System;

    public class HighResolutionDisplay:IDisplay
    {
        public void Display()
        {
            Console.WriteLine("Hign resolution display");
        }
    }
}