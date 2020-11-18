using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class Methodeg
    {
        //We use variables in 2 different methods
        //so we need to declare it in class and 
        //not in single method. Bcoz scope will bcum 
        //local the

        string name;
        int age;

        void GetUserDetails()
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());

        }

        void DisplayDetails()
        {
            Console.WriteLine("USERNAME: {0} and user age is: {1}", name, age);

        }
        static void Main()
        {
            Methodeg m = new Methodeg();
            m.GetUserDetails();
            m.DisplayDetails();

            Console.Read();
        }
    }
}
