using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        /// <summary>
        ///     This is the main file where the choice is requesed from the user for creating a staff objet or a student object
        ///     Details of 5 student is requested and the class average is computed
        ///     By getting the Paper details and experience, bonus for the staff can be calculated.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choice;
            int staffCount = 0, studentCount = 0 ;
            float staffBonus;
              

            do
            {
                Console.WriteLine("\n\nPlease Enter your choice \n 1.Student \n 2.Staff \n Press 0 to exit");
                choice = int.Parse(Console.ReadLine());
                 switch (choice)
                 {
                     case 1:
                         Console.WriteLine("Requesting the Details of 5 Students");
                         Console.WriteLine("************************************");
                         while(studentCount<5)
                         {
                         Console.WriteLine("Please Enter Name");String name = Console.ReadLine();                         
                         Console.WriteLine("Please Enter Age");int age = int.Parse(Console.ReadLine());                         
                         Console.WriteLine("Please Enter Mark1");int m1 = int.Parse(Console.ReadLine());
                         Console.WriteLine("Please Enter Mark2");int m2 = int.Parse(Console.ReadLine());
                         int id = 101;
                                     CStudent S1 = new CStudent(name, age,m1,m2,id);
                                     float  s = S1.Calculate();
                                     S1.setTotal(s);
                                  
                                     id++;
                                     Console.WriteLine("Count of objects created :" + CPerson.getCount());
                                     studentCount++;
                         }
                         Console.WriteLine("Total mark of the class :" + CPerson.getClassMark());  
                         break;
                     case 2:                                   
                         Console.WriteLine("Please Enter Staff name"); String Sname = Console.ReadLine();
                         Console.WriteLine("Please Enter Age"); int Sage = int.Parse(Console.ReadLine());
                         Console.WriteLine("Please Enter years of Experience "); int Sexp = int.Parse(Console.ReadLine());
                         Console.WriteLine("Please Enter Number of paper published"); int Snopp = int.Parse(Console.ReadLine());
                         int Sid = 1001;
                         CStaff St1 = new CStaff(Sname, Sage,Sexp, Snopp, Sid);
                         staffBonus = St1.Calculate();
                         Console.WriteLine("\nBonus for this staff based on experience and papers published :" + staffBonus);
                         staffCount++; Sid++;
                         Console.WriteLine("Count of objects created :" + CPerson.getCount());
                         break;
                     case 0:
                                     break;

                 }
            } while (choice !=0);
            
            CPerson P1 = new CStudent("Advik", 20, 100, 90, 103);// To demonstrate the concept of overriding, a sample object is created
            float tot = P1.Calculate();
            Console.WriteLine("\nCalling Override function \n Average of Student =" + tot );
            Console.ReadLine();
        }
    }


}
