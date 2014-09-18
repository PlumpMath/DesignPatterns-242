namespace AbstractFactory
{
    public class LowResolutionDocumentFactory:DocumentFactory
    {
        public override IDisplay GetDisplay()
        {
            return new LowResolutionDisplay();
        }

        public override IPrint GetPrint()
        {
            return new LowResolutionPrint();
        }
    }
}