namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WordCounter file1 = new WordCounter("1 1 1");
            file1.DisplayAll();

            WordCounter file2 = new WordCounter("This is a statement, and so is this.");
            file2.DisplayAll();

            WordCounter file3 = new WordCounter(string.Empty);
            file3.DisplayAll();

            WordCounter file4 = new WordCounter("21312 2452 123 123!!$$%#$^&$%");
            file4.DisplayAll();
        }
    }
}
