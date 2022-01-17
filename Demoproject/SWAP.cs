using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoproject
{
    public class SwapNumbers
    {

        public static void SwapingNumbers()
        {
           
            int firstNum, secondNum,temp=0;
            Console.WriteLine("Enter the Number to Swap");
             firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second num");
           secondNum = Convert.ToInt32(Console.ReadLine());

            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("swap numbewrs are " + firstNum  +" " +secondNum);
        }
      
    }
}
