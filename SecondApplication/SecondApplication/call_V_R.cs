using System;

namespace SecondApplication
{//call by value, call by reference
    class Call_V_R
    {
        private int num;

        public Call_V_R(int num)
        {
            this.num = num;
        }

        public Call_V_R()
        {
        }

        void ByValue(int value)
        {
            //Scope of variable value is local, only till ByValue
            value = 200;
            Console.WriteLine("Inside call by Value: {0}", value);
        }

        void ByReference( ref int value)
            //Since we're referencing the address
        {
            value = 300;
            Console.WriteLine("Inside call by Referebce: {0}", value);

        }

        //OUT PARAMETER MUST BE PREDECLARED IN main function
        void Calculation(int value1, int value2, out int Add, out int Mul)
        {
            Add = value1 + value2;
            Mul = value1 * value2;
        }
        static void Main()
        {
            int num = 100;
            int Add = 0;
            int Mul = 0;
            //new-> allocates memory for object
            //Call_V_R c = new Call_V_R();
            new Call_V_R().ByValue(num);
            Console.WriteLine("Number {0}", num);
            //Anonymous Object: Di=uring compilation object created

           
                     Console.WriteLine("-----------------------");

            new Call_V_R().ByReference(ref num);
            Console.WriteLine("Number {0}", num);

            Console.WriteLine("-----------------------");
            new Call_V_R().Calculation(20, 60, out Add, out Mul);
            if(Add>0 && Mul > 0)
            {
                Console.WriteLine("Summ is: {0} and Mul is: {1}", Add, Mul);
            }
            Console.WriteLine("---------*****------------");
            Call_V_R c = new Call_V_R();
            c.ByValue(num);

            Console.WriteLine("Final NO. {0}", num);


            Console.ReadKey();
        }
    }
}
