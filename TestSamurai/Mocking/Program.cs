namespace TestSamurai.Mocking
{
    public class Program
    {
        public static void Main()
        {
            VideoService? service = new();
            _ = service.ReadVideoTitle();
        }
    }
}
