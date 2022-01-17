using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoproject
{
    public class pallindrome
    {
        public static void Pallindrome()
       {
            Console.Write("Enter the Number:") ;
            int n, r, sum = 0, temp;
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum= (sum*10)+r;
                n= (n/10);
       
            }
            if (temp == sum) 
            Console.Write("Number  is  Pallindrome");

            else
Console.Write("This Numberis not a Pallindrome");




}
    }
}
