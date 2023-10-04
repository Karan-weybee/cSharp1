using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class a
    {
        public int i = 0;
        public a()
        {
            Console.WriteLine("constructor initilize");
        }

        public void karan(int j)
        {
            this.i = j;
            Console.WriteLine("method called");
            Console.WriteLine(i);
        }
        ~a()
        {
            Console.WriteLine("distructor initialize");
        }
    }
    class Program
    {
      
        public static void callBy(out int a)
        {
            a = 3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            try
            {

                int element = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(element);
                int a;
                Console.WriteLine("hello");
                Class1 c = new Class1();
                c.demo();
                callBy(out a);
                Console.WriteLine(a);

                Console.WriteLine("cw + enter + tab");
                int[][] arr = new int[2][];
                arr[0] = new int[] { 6, 6, 7, 8 };
                arr[1] = new int[] { 2, 3 };
                Console.WriteLine(arr.Length);
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write(arr[i][j] + "k ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Argument length: " + args.Length);
                Console.WriteLine("Supplied Arguments are:");
                foreach (Object obj in args)
                {
                    Console.WriteLine(obj);
                }
            
                //pattern 
                Pattern p = new Pattern(); 
                p.patern(5);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("not valid " + ex);
            }

            a a1 = new a();
            a1.karan(8);
            a a2 = new a();
            a2.karan(8);
            Console.ReadLine();
        }
    }
}
