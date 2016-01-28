namespace ConsoleApplication
{
    public class Calculator
    {
        public int FirstNumber { set; private get; }
        
        public int SecondNumber { set; private get; }

        private int result { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

    }
}
