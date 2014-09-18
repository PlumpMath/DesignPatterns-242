namespace AbstractFactory
{
    public class NewWordDocument
    {
        private DocumentFactory _factory;
        public NewWordDocument(DocumentFactory factory)
        {
            _factory = factory;
        }

        public void Display()
        {
            var d = _factory.GetDisplay();
            d.Display();
        } 

        public void Print()
        {
            var p = _factory.GetPrint();
            p.Print();
        }
    }
}