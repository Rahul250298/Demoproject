using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoproject
{
    public class    Access
    {
        public static void login()
        {

            var input = Console.ReadLine();
            var password = "myself";
            if (input == password)
            {
                Console.WriteLine("acc opening");
                 
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
        }

    }
    
    }
