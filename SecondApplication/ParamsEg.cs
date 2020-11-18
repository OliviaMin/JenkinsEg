using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class ParamsEg
    {
        void Total(string id, params int[] Marks)
        {
            int sum = 0;
            foreach(int m in Marks)
            {
                sum = +m;
            }
        }

        void ObjParam(int id, params object[] Student)
        {
            Console.WriteLine(id);
            foreach(object stu in Student)
            {
                Console.WriteLine(stu);
            }

        }
        static void Main()
        {
            string id = "501638";
            //int[] Mark = { 89, 42, 24, 87 };
            //new ParamsEg().Total(Id,Mark);
            new ParamsEg().Total(id, 89, 42, 24, 87);
            new ParamsEg().ObjParam(1001, "Olivia", "HR", 56000);

            Console.ReadKey()
;        }
    }
}
