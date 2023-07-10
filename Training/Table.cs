using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Table
    {
        public void CreateTable()
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int p = n * i;
                Console.WriteLine(n + "*" + i + "=" + p);
            }
        }
    }
}
