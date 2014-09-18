namespace AbstractFactory
{
    public class WordDocument
    {
        private int _resolution;
        public WordDocument(int resolution)
        {
            _resolution = resolution;
        }

        public void Display()
        {
            switch (_resolution)
            {
                case 1:new LowResolutionDisplay().Display();
                    break;
                case 2:new HighResolutionDisplay().Display();
                    break;
            }
        }

        public void Print()
        {
            switch (_resolution)
            {
                case 1:new LowResolutionPrint().Print();
                    break;
                case 2:new HighResolutionPrint().Print();
                    break;
            }
        }
    }
}