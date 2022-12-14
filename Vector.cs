using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public delegate int CalculateDelegate(int[] arr);
    public delegate object ElementDelegate(object[] arr, object obj);
    public delegate void ExampleDelegate(int i);
    
    internal class Vector
    {
        private int[] arr;
        private CalculateDelegate calculateDelegate;
        private static string result = "";

        public CalculateDelegate CalculateDelegateProperty { get => calculateDelegate; set => calculateDelegate = value; }
        public string Result { get => result; set => result = value; }

        public Vector()
        {
            arr = new int[] { 1, 2, 1, 3, 1, 4 };
        }
        
        public Vector(int[] arr, CalculateDelegate calculateDelegate)
        {
            this.arr = arr;
            //CalculateDelegateProperty = calculateDelegate; 
            this.calculateDelegate = calculateDelegate;
        }
        public string GetStringArr()
        {
            //string result = "";
            //int res = calculateDelegate(arr);
            result += calculateDelegate(arr).ToString() + " ";
            return result;
        }
        public void Method()
        {
            foreach (var item in calculateDelegate.GetInvocationList())
            {
                Console.WriteLine(item.ToString());
            }
        }
       
    }
}
