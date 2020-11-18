using System;

namespace SecondApplication
{
   class Department {
        int Did;
        string dname, Location;
        internal static string Orgname;
        //string Orgname;

        internal Department()
        {
            Console.WriteLine("Default Constructor");
        }
        //constructor overloading

        /*internal Department(string Orgname)
        {
            this.Orgname = Orgname;
                //Commented only for ClientDepartmentStatic. If execiting ClientDepartment example, Remove comment and make u   }
        */
        internal Department(int id, string name, string location)
        {
            Did = id;
            dname = name;
            this.Location = location;
        }

        internal void DisplayOrg()
        {
            Console.WriteLine("Organisation name: {0}", Orgname);

        }
        internal void Display()
        {
            Console.WriteLine("ID: {0} || Dname: {1} || Location: {2}", Did, dname, Location);

        }

       


    }

    class ConstructorEg

    {
        static void Main()
        {
                        
            new Department();
            //new Department("LTI").DisplayOrg();
            Department dp = new Department(100,"HR","Mumbai");
            dp.Display();
       
            Console.ReadKey();
        }
    }
}
