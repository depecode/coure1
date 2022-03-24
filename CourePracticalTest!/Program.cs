using System;
using System.Collections.Generic;

namespace CourePracticalTest_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is total number of array you want to enter?");
            var totalNumber = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[totalNumber];
            Console.WriteLine("Please Enter the {0} numbers", totalNumber);

            for (int i = 0; i < totalNumber; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int point = 0;

            foreach (int d in array)
            {
                if(d%2 == 0 && d == 8)
                {
                    point += 6;
                }else if (d % 2 == 0)
                {
                    point += 1;
                }
                else
                {
                    point += 3;
                }
            }

            Console.WriteLine("The total points is {0}", point);


        }
    }
}
