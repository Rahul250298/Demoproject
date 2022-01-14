using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoproject
{
     class ReverseNumber
    {
        public statc void FindReverseNumber()
        {
            Console.WriteLine("please enter number to reverse");
            int number=Convert.ToInt32(Console.ReadLine()); 
            int remainder,reverse=0;
            while(number>0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
        }
    }
}
