using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    delegate int CalculateDelegate(int[] arr);
    
    internal class Vector
    {
        private int[] arr;
        private CalculateDelegate calculateDelegate;
       
        public Vector(int[] arr, CalculateDelegate calculateDelegate)
        {
            this.arr = arr;
            this.calculateDelegate = calculateDelegate; 
        }
        public string GetStringArr()
        {
            string result = "";
            int res = calculateDelegate(arr);
            result += res.ToString();

            return result;
        }
       
    }
}
