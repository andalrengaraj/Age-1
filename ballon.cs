using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ballon_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of testcases");
            int no_of_testcase = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= no_of_testcase; j++)
            {
                Console.WriteLine("Enter the cost of green ballon");
                int cost_green = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the cost of purple ballon");
                int cost_purple = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the no of participants ");
                int no_participants = Convert.ToInt32(Console.ReadLine());
                int sum_a = 0;
                int sum_b = 0;
                for (int i = 1; i <= no_participants; i++)
                {
                    Console.WriteLine("Enter the status for problems for participant {0},Press 1 for win ,Press 0 for lose", +i);
                    Console.WriteLine("Enter the status for problem  A");
                    int a = Convert.ToInt32(Console.ReadLine());
                    sum_a = sum_a + a;
                    Console.WriteLine("Enter the status for problem  B");
                    int b = Convert.ToInt32(Console.ReadLine());
                    sum_b = sum_b + b;



                }
                ///Console.WriteLine(sum_a);
                ///Console.WriteLine(sum_b);
                int small_in_count = smallest_of_2(sum_a, sum_b);
                int largest_in_count = largest_of_2(sum_a, sum_b);
                int ans = 0;
                int ans_1 = 0;
                if (cost_green > cost_purple)
                {
                    ans = small_in_count * cost_green;
                }
                else
                {

                    ans = small_in_count * cost_purple;
                }
                if (cost_green < cost_purple)
                {
                    ans_1 = largest_in_count * cost_green;
                }
                else
                {
                    ans_1 = largest_in_count * cost_purple;
                }

                //Console.WriteLine(ans);
                //Console.WriteLine(ans_1);
                int res = ans + ans_1;
                Console.WriteLine(res);
            }






        }
        static public int smallest_of_2(int num1, int num2)
        {

            if (num1 > num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }

        }
        static public int largest_of_2(int num1, int num2)
        {

            if (num1 < num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }

        }




    }
}


