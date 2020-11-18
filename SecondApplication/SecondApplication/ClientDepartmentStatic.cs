using System;

namespace SecondApplication
{
    class ClientDepartmentStatic
    {
        static void Main()
        {
            Console.WriteLine("Main Function Begins");
            Console.WriteLine("Enter Organisation name");
            Department.Orgname = Console.ReadLine();
            new Department();
            new Department().DisplayOrg();
            Department db = new Department(100, "HR", "Mumbai");
            db.Display();

            Department[] deptarray = new Department[3];
            deptarray[0] = new Department(101, "Sales", "Chennai");
            deptarray[1] = new Department(102, "Finance", "Pune");
            deptarray[2] = new Department(103, "Marketing", "Delhi");

            foreach (Department d in deptarray)
            {
                d.Display();
            }

            //dp.Display();
            Console.ReadKey();
        }
    }
}
