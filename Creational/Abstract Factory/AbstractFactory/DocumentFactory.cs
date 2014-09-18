namespace AbstractFactory
{
    public abstract class DocumentFactory
    {
        public abstract IDisplay GetDisplay();

        public abstract IPrint GetPrint();
    }
}