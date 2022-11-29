using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public delegate T OperationDelegate<T>(List<T> list);

    internal class Demo
    {
        public static void Start()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13 };
            OperationDelegate<int> operation = GetMax;
            Console.WriteLine(operation.Invoke(list));
        }
        public static int GetMax(List<int> list)
        {
            return list.Max();
        }
        public static int GetMin(List<int> list)
        { 
            return list.Min(); 
        }
    }
}
