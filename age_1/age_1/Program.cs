﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_1
{
    class Program
    {
        static void Main(string[] args)
        {
//basic Get_age:
            //Console.WriteLine("ENter yoyr name :");
            //string name=Console.ReadLine();
            Console.WriteLine("ENter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Get_age(age));
            //if(age >= 60) 
            //{
            //    Console.WriteLine(" {0} ,YOU ARE OLD",name);
            //}
            //else if (age>=20)
            //{
            //    Console.WriteLine("{0},YOU ARE YOUNG",name);
            //}
            //else {
            //    Console.WriteLine("{0},YOU ARE CHILD",name);
            //}




        }
 //USING MULTIPLE RETURN AND IF ,ELSE:(Should use else)
        //static public string Get_age(int age)
        //{
        //    if (age >= 60)
        //    {
        //        return "Old";

        //    }
        //    else
        //    {
        //        return "YOUNG";
        //    }
        static public string Get_age(int age)
        {
//Using x
            //no else needed:
            //x value will change according to the conditions:
            string x="child";
                if(age>=60)
                {
                   x="old";

                }
                else if (age >= 20)
                { 
                    x="Young";
                
                }
            return x;
        



        


        }

    }
}
