using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_array_set
{
    class Program
    {
        static void Main(string[] args)
        {
            #region bool_set 2 to true
            //bool[] ma = new bool[25];
            //for (int i = 0; i < ma.Length; i++)
            //{
            //    if (i == 2)
            //    {
            //        ma[i] = true;

            //    }
            //    else
            //    {
            //        ma[i] = false;
            //    }


            //}
            //print_bool_array(ma);
            #endregion

            bool[] ans = seive_of_Eratosthenes(1000);
            print_bool_array(ans);







        }
        static public void print_bool_array(bool[] ma)
        {
            for (int i = 0; i < ma.Length; i++)
            {
                Console.Write(ma[i]+"\t");
            }
            Console.WriteLine();

        }

        static public bool[] set_bool_to_true(bool[] ma)
        {
            //set the bool array to true
            for (int i = 0; i < ma.Length; i++)
            {
                ma[i] = true;
            }
            return ma;

        }

        static public bool[] seive_of_Eratosthenes(int n)
        {
            bool[] ma = new bool[n+1];
            //set the bool array to true;
            for (int i = 0; i < ma.Length; i++)
            {
                ma[i] = true;
            }
            //special case for 0 and 1
            
            for (int i = 0; i * i <= n; i++)
            {
                if (i == 0 || i == 1)
                {
                    ma[i] = false;
                }
                //eratosthenes
                if (ma[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                       
                        ma[j] = false;
                        
                    }
                }
            }
            return ma;

        }

        
    }
}
