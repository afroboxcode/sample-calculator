namespace calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator(); 
            Console.WriteLine($"A soma dos números 1 e 2 é igual a {calc.Soma(1, 2)}");
        }
    }
}