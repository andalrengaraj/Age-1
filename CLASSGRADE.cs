using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("No of student in the class");
            int no_of_students = Convert.ToInt16(Console.ReadLine());
            for (int i1 = 0; i1 < no_of_students; i1++)
            {
                Grade gradebook = new Grade();

                Console.WriteLine("Enter the student name :");
                gradebook.Name = Console.ReadLine();
                Console.WriteLine("ENter the student roll no: ");
                gradebook.RollNo = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Name: " + gradebook.Name + " RollNo: " + gradebook.RollNo);

                Console.WriteLine("Enter the no of subject you have : ");
                int no_of_sub = Convert.ToInt16(Console.ReadLine());
                SortedList<string, double> x = gradebook.getinput(no_of_sub);

                double total = gradebook.total_mark();
                Console.WriteLine("Total Score : " + total + "/" + no_of_sub * 100);
                gradebook.higgest_score();
                gradebook.low_score();
                gradebook.average(total, no_of_sub);


                Console.WriteLine("S.No|" + "Subjects   |" + "Marks|" + "Grade|" + "GradeStatus" + "\n" +
                                  "----|-----------|-----|-----|-----------");
                int i = 1;
                foreach (KeyValuePair<string, double> item in x)
                {


                    Console.WriteLine(i + "   |" + item.Key + "\t|" + item.Value + "   |" + gradebook.grade_display(item.Value) + "    |"
                        + gradebook.grade_status(gradebook.grade_display(item.Value)));
                    i++;

                }










            }
        }
    }
    
        class Grade
        {
        string _name;
        int _rollno;
        int _std; 
        SortedList<string, double> ml =  new SortedList<string,double>();
       
        public SortedList<string,double> getinput(int no_of_subjects)
        {
             for (int i = 1; i <= no_of_subjects; i++)
            {
                Console.WriteLine("Enter the subject Name:");
                string sub_name = Console.ReadLine();
                Console.WriteLine("Enter the Mark for this subject");
                double sub_mark = Convert.ToDouble(Console.ReadLine());
                

                if (sub_mark > 0 && sub_mark <= 100)
                {
                    ml.Add(sub_name, sub_mark);
                    
                }


            }
            
            
            return ml;


        }

        public double total_mark()
        {
            double t = 0;
            foreach (KeyValuePair<string, double> d in ml)
            {
                t = t + d.Value;
            }
           // Console.WriteLine("Total "+t);
            return t;
        }

        public void higgest_score()
        {
            double high = int.MinValue;
            string high_sub="";
            foreach (KeyValuePair<string, double> d in ml)
            {
                if (high < d.Value)
                {
                    high = d.Value;
                    high_sub=d.Key;
                }
               
            }
            Console.WriteLine("Highest Score : " + high + " in " + high_sub); 
        }

        public void low_score()
        {
            double low = int.MaxValue;
            string low_sub = "";
            foreach (KeyValuePair<string, double> d in ml)
            {
                if (low>d.Value)
                {
                    low = d.Value;
                    low_sub= d.Key;
                }

            }
            Console.WriteLine("Lowest Score : " + low+ " in " + low_sub);
        }

        public void average(double total,int no_of_sub)
        {
            double avaerage = total / no_of_sub;
            Console.WriteLine("Average:  "+avaerage);
        }

        public string grade_display(double value)
        {
            string grade = "";
               if (value>=90 &&value<=100)
                {
                    grade = "S";
                    
                }
                 else if (value >=80&& value<=89)
                {
                    grade = "A";

                }
                 else if (value >= 70&&value<=79)
                {
                    grade = "B";

                }
                else  if (value >= 60&& value<=69)
                {
                    grade = "C";

                }
                else  if (value>= 50&&value<=59)
                {
                    grade = "D";

                }
               else if (value<50)
               {
                   grade = "F";
               }

              
            return grade;
 }

        public string  grade_status(string s)
        {
            string status = "";
            if (s== "S")
            {
                status = "Distinction";

            }
            else  if (s== "A"||s=="B")
            {
                status = "First class";

            }
            else  if (s== "C"||s=="D")
            {
                status = "Second Class";

            }
            else if (s == "F")
            {
                status="Fail";
            }
            return status;
           

            
           
        }
            
        
        

      


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int RollNo
        {
            get { return _rollno; }
            set { _rollno = value; }
        }
        public int std
        {
            get { return _std; }
            set { _std = value; }
        }




    }
   
}
