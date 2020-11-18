using System;

namespace SecondApplication
{
    class Student
    {
        internal static string CollegeName;
        int id = 101;

        //Non Static Method can access static variable
        internal void DisplayCollegeDetails() {
            Console.WriteLine("CollegeName: {0}", CollegeName);

                  }
        internal static void Display()
        {
            //can't access non static variable in static method
            //Console.WriteLine("CollegeID: {0}",id);
            Console.WriteLine("CollegeID: {0}", CollegeName);
        }
    }
    class StaticEg
    {
        static string phone;
        internal static void DisplayPhone()
        {
            Console.WriteLine("CollegeName: {0}", phone);
        }
        static void Main()
        {
            phone = "236651";
            Console.WriteLine("Enter College Name");
            Student.CollegeName = Console.ReadLine();
            Student student = new Student();
            student.DisplayCollegeDetails();

            //callimg static method of Student class
            Student.Display();

            //calling static fn from StaticEg class
            DisplayPhone();
            Console.ReadKey()
;        }

    }
}
