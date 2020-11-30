using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberProblmes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Min div
            //int num = GetInterger("Enter the num");
            //int ans=min_div(num);
            #endregion

            #region power of 4
            //Console.WriteLine(ans);
            // double ans = Math.Log(12)/Math.Log(4);
            // Console.WriteLine(ans);
            #endregion

            #region amstrong number
            //int num = GetInterger("Enter the num");
            //bool ans = amstrong_num_bool(num);
            //Console.WriteLine(ans);

            #endregion

            #region amstrong number in intervals
            //int start = GetInterger("enter the starting value");
            //int end = GetInterger("Enter the ending value");
            //string  ans = amstrong_interval(start, end);
            //Console.WriteLine(ans);

            #endregion

            # region perfect_sq
           // int num = GetInterger("Enter the num");
           // bool ans = perfect_sq(num);
           // Console.WriteLine(ans);
           #endregion

            #region perfect_upto
            //int num = GetInterger("Enter the num");
            //int ans = perfect_Sq_upto(num);
            //Console.WriteLine(ans);
            #endregion

            #region  next perfect
           // int num = GetInterger("ENter the number");
           // int ans = next_perfect(num);
           // Console.WriteLine(ans);

           #endregion

            #region previous perfect
            //int num = GetInterger("Enter the number");
            //int ans = previous_perfect(num);
            //Console.WriteLine(ans);

            #endregion

            #region nearest perfect square
            //int num = GetInterger("Enter the num");
            //int ans = nearest_perfect(num);
            //Console.WriteLine(ans);

            #endregion

            #region nearest amstrong
            //int num = GetInterger("Enter  the num");
            //int ans = next_amstorng(num);
            //Console.WriteLine(ans);
            #endregion

            #region kth _value
            int k = GetInterger("Enter the k");
            int num = GetInterger("Enter the num");
            int ans = kth_perfect(num,k);
            Console.WriteLine(ans);
             
            #endregion






        }
        static public int min_div(int num)
        {
            int  x = 0;
            int current_digit = num % 10;
            int i = 2;
            while (current_digit != 0)
            {   
                if (current_digit % i == 0)
                {
                
                    num = num / 10;
                    current_digit = num % 10;
                    x = i;    
                }
                else
                {
                    i++;
                }
            }
            return x;
            }

        static public double amstrong_num(int num1)
        {
            int num = num1;
            double pow = 0;
            double  sum = 0;
            int current = 0;
            int count = count_num(num);
            
            while (num != 0)
            {
                current = num % 10;
                pow = Math.Pow(current, count);
                sum = sum + pow;
                num = num / 10;

                
            }
            
           
            if (sum == num1)
            {
                Console.WriteLine("It's a amstrong number");
            }
            else
            {
                Console.WriteLine("Not a Amstrong number");
            }
            return sum;
          


        }

        static public bool amstrong_num_bool(int num1)
        {
            int num = num1;
            double pow = 0;
            double sum = 0;
            int current = 0;
            int count = count_num(num);

            while (num != 0)
            {
                current = num % 10;
                pow = Math.Pow(current, count);
                sum = sum + pow;
                num = num / 10;


            }


            if (sum == num1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        static public int count_num(int num)
        {
            int count = 0;
            int current = 0;
            while (num!=0)
            {
                current = num % 10;
                num = num / 10;
                count++;


            }
            return count;
        }

        static public string amstrong_interval(int start, int end)
        {
            string x = "";
            for (int i = start; i<=end; )
            {
                if (amstrong_num_bool(i))
                {
                    x = x + i +"\t";
                    i++;
                }
                else
                {
                    i++;
                   
                }
              
                

            }
            return x;
            
        }

        static public bool perfect_sq(int num)
        {
            bool x = true;
            double sq1 = Math.Sqrt(num);
            int  sq2 = (int)Math.Sqrt(num);
            if (sq1 == (double)sq2)
            {
                x = true;
            }
            else
            {
                x = false;
            }
            return x;
           
            



        }

        //static public bool perfect_sq_bool(int num)
        //{
        //    bool x=true;
        //    for (int i = 1; i * i <= num; i++)
        //    {
        //        if ((num % i == 0)&& (num / i == i))
        //        {
        //            x= true;
        //        }
        //        else
        //        {
        //            x = false;
        //        }


        //    }
        //    return x;
        //}

        static public int perfect_Sq_upto(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (perfect_sq(i))
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                    
                    
                }
                
                
                   
                

            }
            return sum;


        }

        static public int next_perfect(int num)
        {
            int x = 0;
            int i = num+1;
            int count = 0;
            while (count != 1)
            {
                if (perfect_sq(i))
                {
                    x = i;
                    count++;
                }
                else
                {
                    i++;
                }
            }
            return x;


        }

        static public int previous_perfect(int num)
        {
            int x = 0;
            int count = 0;
            for (int i = num-1; count < 1; i--)
            {
                if (perfect_sq(i))
                {
                    x = i;
                    count++;

                }
            }
            return x;


        }

        static public int nearest_perfect(int num)
        {
            int next = next_perfect(num);
            int previous = previous_perfect(num);
            if ((next - num) > (num - previous))
            {
                return previous;
            }
            else
            {
                return next;
            }
        }

        static public int next_amstorng(int num)
        {
            int x = 0;
            int count = 0;
            int i = num + 1;
            while (count != 1)
            {

                if (amstrong_num_bool(i))
                {
                    x = i;
                    count++;
                }
                else
                {
                    i++;
                }
            }
            return x;
        }

        static public int kth_perfect(int num,int k)
        {
            int i = num+1;
            int count = 0;
            while (count != k)
            {
                if (perfect_sq(i))
                {
                    count++;
                    num = i;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            return num;
        }












        static public int GetInterger(string message)
        {
            Console.WriteLine("******Getting Input from user********");
            Console.WriteLine(message + ":");
            int tempvalue;
            if (!int.TryParse(Console.ReadLine(), out tempvalue))
            {
                return GetInterger("Please enter the valid integer :");
            }
            return tempvalue;
        }
        static public double GetDoublde(string message)
        {
            Console.WriteLine("******Getting Input from user********");
            Console.WriteLine(message + ":");
            double tempvalue;
            if (!double.TryParse(Console.ReadLine(), out tempvalue))
            {
                return GetInterger("Please enter the valid Double :");
            }
            return tempvalue;
        }
        static public string Getstring(string message)
        {
            Console.WriteLine("*********GettingInput*********");
            Console.WriteLine();
            Console.WriteLine(message + ",");
            string tempstring = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tempstring))
            {
                tempstring = Getstring("Please enter valid text");

            }
            return tempstring;


        }
        public static bool isprime(int num)
        {
            if (num == 2 || num == 3)
            {
                return false;
            }
            int prime_count = 0;
            for (int i = 2; i <= (num / 2); i++)
            {
                
                if (num % i == 0)
                {
                    prime_count++;
                }

            }
            if (prime_count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
