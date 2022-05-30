using System;

namespace homeWork001
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            Console.Write("Напишите имя: ");
            name = Console.ReadLine();
            Console.Write("Символ: ");
            symbol = Convert.ToChar(Console.ReadLine());
            int howMuchSymbols = Convert.ToInt32 (name.Length);
            var symbols = new string(symbol, howMuchSymbols + 2);
            Console.WriteLine(symbols + "\n" + symbol + name + symbol + "\n" + symbols);
        }
    }
}
