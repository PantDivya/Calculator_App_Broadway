using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App_Broadway
{
    internal class Addition
    {
        public void Add(int[] addInputs)
        {
            int result = 0;
            foreach (int num in addInputs)
            {
                result += num;
            }
            Console.WriteLine("The addition is: " + result);
        }    
    }
}
