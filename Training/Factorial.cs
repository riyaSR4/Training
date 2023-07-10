using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Factorial
    {
        public void FactorialOfNumber()
        {
            int fact = 1;
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial is :" + fact);

        }

    }
}
