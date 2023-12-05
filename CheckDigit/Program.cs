namespace CheckDigit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input != null && input != "" && input.Length == 16)
                {
                    Console.WriteLine($"Card number validity: {DigitChecker.Check(input)}.");
                }

                else
                {
                    Console.WriteLine("Please write a card number to check");
                }
            }
        }
    }
}