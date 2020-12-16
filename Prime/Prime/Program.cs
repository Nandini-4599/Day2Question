using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the minimum number");

            
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the maximum number");

            int max = int.Parse(Console.ReadLine());
            int flag = 0;

            for(int i=min;i<=max;i++)
            {
                if (i == 1 || i == 0)
                    continue;

                
                flag = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

           
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
