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
           // int num = GetInterger("Enter the num");
           //int ans = min_div_1(num);
           //Console.WriteLine(ans);
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
           // bool ans = perfect_sq_1(num);
          //  Console.WriteLine(ans);
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

            #region kth _value of perfect sq
            //int k = GetInterger("Enter the k");
            //int num = GetInterger("Enter the num");
            //int ans = kth_perfect(num,k);
            //Console.WriteLine(ans);
             
            #endregion

            #region kth amstrong number not suitable for large values
            //int k = GetInterger("Enter the k");
            //int num = GetInterger("Enter the num");
            //long ans = kth_amstrong(num, k);
            //Console.WriteLine(ans);
            
            #endregion 

            #region ispalindrome
           // int num = GetInterger("Enter the num");
           // bool ans = palindrome(num);
           /// Console.WriteLine(ans);
            #endregion

            #region previous_pali
           // int num = GetInterger("Enter the num");
           // int ans = prev_pali(num);
           // Console.WriteLine(ans);
            #endregion

            #region next_pali
           // int num = GetInterger("Enter the num");
           // int  ans = next_pali(num);
           // Console.WriteLine(ans);
            #endregion

            #region kth_pali
            // int num = GetInterger("Enter the num");
            // int k = GetInterger("enter the k");
            //int  ans = kth_pali(num,k);
            /// Console.WriteLine(ans);
            #endregion

            #region GCD
            //int num1 = GetInterger("enter the num");
            //int num2 = GetInterger("Enter the num2");
            //int num3 = GetInterger("Enter the num3");

            //int ans_1 = gcd_3(num1, num2, num3);
            //Console.WriteLine(ans_1);


            #endregion

            #region LCM
            //int num1 = GetInterger("Enter the num1");
            //int num2 = GetInterger("Enter the num2");
            //int num3 = GetInterger("enter the num3");
            //long ans = lcm_3(num1, num2, num3);
            //Console.WriteLine(ans);
            #endregion

            #region pow_of_4
            //int num1 = GetInterger("enter the num1");
            //int ans = power_of_4(num1);
            //Console.WriteLine(ans);
             
            #endregion

            #region pow_of_n
            //int num = GetInterger("Enter the num1");
            //int k = GetInterger("Enter the k");
            //int ans = power_of_n(num, k);
            //Console.WriteLine(ans);
            #endregion

            #region fibo
          //  int  num1 = GetInterger("enter the num");
          // string   ans = fibo(num1);
         //  Console.WriteLine(ans);
            #endregion

            #region next_fibo
           // int num = GetInterger("Enter the num");
          //long ans = next_fibo(num);
         //  Console.WriteLine(ans);

            #endregion

            #region without_sqrt
           // int num1 = GetInterger("Enter the num");
           //int ans = without_sqrt(num1);
           //Console.WriteLine(ans);
            #endregion

            #region count
            //int num = GetInterger("Enter the num");
            //int ans = count_the_num(num);
            //Console.WriteLine(ans);


            #endregion

            #region amstrong number of generic case
            //int num = GetInterger("Enter the num");
            //string ans = amstrong_interval_1(num);
            //Console.WriteLine(ans);
            #endregion

            #region next_fibo
            //int num = GetInterger("Enter the num");
            //double ans = next_fibo(num);
            //Console.WriteLine(ans);


            #endregion

            #region pre_fibo
            //int num = GetInterger("Enter the num");
            //double ans = pre_fibo(num);
            //Console.WriteLine(ans);


            #endregion

            #region isfibo
            //double num = GetDoublde("enter the num");
            //bool ans = isfibo(num);
            //Console.WriteLine(ans);



            #endregion

            #region find_i_fibo
            int  num = GetInterger("enter the num");
            double ans = find_i_fibo(num);
            Console.WriteLine(ans);



            #endregion













        }



        static public void min_div(int num)
        {
            int counts = 0;
            for (int i = 2; i <= 9; i++)
            {
                int count = 0;
                while (num != 0)
                {
                    int mod = num % 10;
                    if (mod % i == 0)
                    {
                        count += 1;
                    }
                    num = num / 10;

                }
                if (count == 4)
                {
                    Console.WriteLine(i);
                    counts += 1;


                }


            }
            if (counts == 0)
            {
                Console.WriteLine(0);
            }
            Console.ReadLine();
        }

        static public int min_div_1(int num)
        {
           
            int input_num=num;
            int x = 0;
            int current_dig=num%10;
            while (num != 0)
            {
                for (int i = 2; i <= 9;)
                {
                    if (current_dig == 0 || num == 0)
                    {
                        break;
                    }
                       
                    
                    if (current_dig % i == 0)
                    {
                       
                        num = num / 10;
                        Console.WriteLine(num);
                        current_dig = num % 10;
                        Console.WriteLine(current_dig);
                       
                       
                    }
                       
                    else
                    {
                        i++;
                        
                        
                        
                    }
                }


            }
            return x;
        }

        static public double amstrong_num(int num1)
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
        
        static public bool perfect_sq_1(double num)
        {
            bool x = false;
            for (int i = 1; i * i <= num; i++)
            {
                if (num % i == 0 && num / i == i)
                {

                    x = true;

                }
                
                
                
            }
            return x;
        }

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

        static public int next_pali(int num)
        {
            int x = 0;
            int i = num + 1;
            int count = 0;
            while (count != 1)
            {
                if (palindrome(i))
                {
                    x = i;
                    count++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            return x;
        }

        static public int kth_amstrong(int num, int k)
        {
            int i = num + 1;
            int count = 0;
            while (count != k)
            {
                if (amstrong_num_bool(i))
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

        static public bool palindrome(int num)
        {
            bool x = true;
            int compare_num = num;
            int rem = 0;
            int rev = 0;
            while (num != 0)
            {
                rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;
            }

            if (compare_num == rev)
            {
                x = true;
            }
            else
            {
                x = false;
            }
            return x;

        }

       
        static public int prev_pali(int num)
        {
            int x = 0;
            int i = num -1;
            int count = 0;
            while (count != 1)
            {
                if (palindrome(i))
                {
                    x = i;
                    count++;
                    i--;
                }
                else
                {
                    i--;
                }
            }
            return x;
        }

        static public int kth_pali(int num, int k)
        {
            int i = num + 1;
            int count = 0;
            while (count != k)
            {
                if (palindrome(i))
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

        static public int gcd_num(int num1, int num2)
        {

            if (num2 == 0)
            {
                return num1;
            }

                return gcd_num(num2, num1 % num2);
            }

        static public int gcd_3(int num1,int num2, int num3)
        {
            int  ans_of_2 = gcd_num(num1, num2);
            if (num3 == 0)
            {
                return ans_of_2;
            }
            return gcd_num(num3, ans_of_2 % num3);
        



        }

        static public int  lcm_2(int num1, int num2)
        {
            int   gcd_of_2 = gcd_num(num1, num2);
            int  pro = num1 * num2;
            int  lcm = pro / gcd_of_2;

            return lcm;
        }

        static public long lcm_3(int  num1, int   num2, int   num3)//
        {
            int   lcm_of_2 = lcm_2(num1, num2);
            long lcm_of_3 = lcm_2(lcm_of_2, num3);
            return lcm_of_3;


        }

        static public int power_of_4(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            while (num != 1)
            {
                if (num % 4 != 0)
                {
                    return 0;
                }
                num = num / 4;

            }
            return 1;
        }

        static public int power_of_n(int num, int k)
        {
            while (num != 1)
            {
                if (num % k != 0)
                {
                    return 0;
                }
                num = num / k;
            }
            return 1;
        }

        static public string fibo(int num)
        {
            string x = "";
            long a = 0;
            long b = 1;
            long c = 0;
            if (num == 0)
            {
                x=x+num;
            }
            else if (num == 1)
            {
                x= x+num;
            }
            else
            {
                for (int i = 2; i<= num; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    x = x + b + "\t";


                }
            }
            return x;
        }

        static public long fibo_1(int num)
        {
            long x = 0;
            long a = 0;
            long b = 1;
            long c = 0;
            if (num == 0)
            {
               x= num;
            }
            else if (num == 1)
            {
                x = num;
            }
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    x = b;


                }
            }
            return x;
        }

        static public int without_sqrt(int num)
        {
            int  x = 0;
            for (int i = 1; i * i <= num; i++)
            {
                if (num / i == i)
                {

                    x=i;

                }



            }
            return x;
        }

        static public int count_the_num(int num)
        {
            int current = 0;
            int count = 0;
            while (num != 0)
            {
                current = num % 10;
                num = num / 10;
                count++;
            }
            return count;


        }

        static public string amstrong_interval_1(int n)
        {
            string  x = "";
            
            int i = 2;
            while (count_the_num(i) !=n+1)
            {

                if (amstrong_num_bool(i))
                {
                    if (count_the_num(i) <= n)
                    {

                        x = x + i + "\t";
                        i++;
                    }

                }
                else
                {
                    i++;

                }
            }



            
            return x;

        }

        static public double  next_fibo(int num)
        {
            double ans1 = Math.Sqrt(5);
            double ans2 = (ans1 + 1) / 2;
            double ans3 = Math.Round(num * ans2);
      
            return ans3;
        }

        static public double pre_fibo(int num)
        {
            double ans1 = Math.Sqrt(5);
            double ans2 = (ans1 + 1) / 2;
            double ans3 = Math.Round(num / ans2);

            return ans3;
        }

        static public bool isfibo(double num)
        {
            bool x = false;
            double ans1 =5*( Math.Pow(num, 2));
            double ans2 = ans1 + 4;
            double ans3 = ans1 - 4;
            if(perfect_sq_1(ans2) || perfect_sq_1(ans3))
            {
                x = true;

            }
            return x;
        
        }

        static public double  find_i_fibo(long num)
        {
            double ans1 = Math.Log(num); 
            double ans1_1=    (Math.Log(5) / 2);
            double ans_1 = ans1 + ans1_1;
            double ans2 = Math.Log((Math.Sqrt(5) + 1) / 2);
            double ans =Math.Round( ans_1 / ans2);
            return ans;

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
        static public long Getlong(string message)
        {
            Console.WriteLine("******Getting Input from user********");
            Console.WriteLine(message + ":");
            long tempvalue;
            if (!long.TryParse(Console.ReadLine(), out tempvalue))
            {
                return Getlong("Please enter the valid integer :");
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
