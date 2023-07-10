using System;
using Training;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter input to be executed\n 1.Fibonacci Series\n 2.Factorial\n " +
                    "3.OddOrEven\n 4.Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Fibonaacci fibonacci = new Fibonaacci();
                        fibonacci.FibonaacciSeries();
                        break;
                    case 2:
                        Factorial factorial = new Factorial();
                        factorial.FactorialOfNumber();
                        break;
                    case 3:
                        OddOrEven oddOrEven = new OddOrEven();
                        oddOrEven.CheckOddOrEven();
                        break;
                    case 4:
                        Table table = new Table();
                        table.CreateTable();
                        break;
                    case 5:
                        Swap swap = new Swap();
                        swap.SwapTwoNumbers();
                        break;
                    case 6:
                        ConsonantOrVowel consonantOrVowel = new ConsonantOrVowel();
                        consonantOrVowel.CheckConsonantOrVowel();
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}
