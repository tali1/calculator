using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class FizzBuzz
    {
        public void dirtySlut()
        {
            for (int i =1; i < 101; i++)
            {
                var bigSlut = "";
                if (i % 3 == 0)
                {
                    bigSlut += "Fizz";
                }

                if (i % 5 == 0) 
                
                {
                    bigSlut += "Buzz";
                }


                if(bigSlut == "")
                {
                    bigSlut = i.ToString();
                }

                Console.WriteLine(bigSlut);
            }
        }
    }
}
