namespace AbstractFactory
{
    public class HighResolutionDocumentFactory:DocumentFactory
    {
        public override IDisplay GetDisplay()
        {
            return new HighResolutionDisplay();
        }

        public override IPrint GetPrint()
        {
            return new HighResolutionPrint();
        }
    }
}