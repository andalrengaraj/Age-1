using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name please: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name + "!! " +"Nice to meet you" );

            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            int yourage = Convert.ToInt32(age);
            Console.WriteLine("Your are " + yourage +" years old");


            Console.WriteLine("Enter your height: ");
            string height = Console.ReadLine();
            decimal myheight = Convert.ToDecimal(height);
            Console.WriteLine("Your height is " + myheight);

            Console.WriteLine("Enter your Roll no: ");
            string rollno = Console.ReadLine();
            int myrollno = Convert.ToInt32(rollno);
            Console.WriteLine("your roll no " + myrollno);

            Console.WriteLine("Enter your fav food : ");
            string food = Console.ReadLine();
            Console.WriteLine("WOW!!!,I too love " + food);

            Console.WriteLine("Enter the date and time");
            string dateandtime = Console.ReadLine();
            DateTime mydateandtime = Convert.ToDateTime(dateandtime);
            Console.WriteLine("The date and time :" + dateandtime);

            Console.WriteLine("enter your hobbies:");
            string hobbies = Console.ReadLine();
            Console.WriteLine("Good one " + name);


         


           
        



        }
    }
}
