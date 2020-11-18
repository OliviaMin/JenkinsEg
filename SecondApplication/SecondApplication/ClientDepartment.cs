using System;

namespace SecondApplication
{
    class ClientDepartment
    {
        static void Main()
        {
            Console.WriteLine("Main Function Begins");
            new Department();
            //new Department("LTI").DisplayOrg();
            Department dp = new Department(100, "HR", "Mumbai");

            //Multiple Department
            //Array of Object

            Department[] deptarray = new Department[3];
            deptarray[0] = new Department(101, "Sales", "Chennai");
            deptarray[1] = new Department(102, "Finance", "Pune");
            deptarray[2] = new Department(103, "Marketing", "Delhi");

            foreach(Department d in deptarray){
                d.Display();
            }

            dp.Display();
            Console.ReadKey();
        }
    }
}
