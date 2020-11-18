  using System;


namespace SecondApplication
{
    class ObjectOriented
    {
        string OrgName;
        int oid;

        void DisplayDetails()
        {
            Console.WriteLine(OrgName + "  " + oid);
        }
        static void Main(String[] args)
        {
            ObjectOriented obj = new ObjectOriented();
            obj.oid = 101;
            obj.OrgName = "LTI";
            obj.DisplayDetails();
            //Displlays LTI 101
            ObjectOriented obj2 = new ObjectOriented();
            obj2.OrgName = "FCRIT";
            obj2.DisplayDetails();

            //Displays FCRIT 0 bcoz nothing is initialised, so default value 0
            Console.ReadKey();

        }
    }
}
