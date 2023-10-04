using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Pattern
    {
        public void patern(int n)
        {
            Console.WriteLine(n);
            char ch;
            for (int i = 1; i <= n; i++)
            {
                ch = 'A';
                for (int j = 0; j < i; j++)
                {
                    Console.Write(ch+" ");
                    ch++;
                }
                ch--;
                for (int j = 0; j < i-1; j++)
                {
                    ch--;
                    Console.Write(ch+" ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
