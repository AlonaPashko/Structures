using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public static class VariableScopeWithLambdas
    {
        public class VariableCaptureGame
        {
            internal Action<int>? updateCaptureLocalVariable;
            internal Func<int, bool>? isEqualToCaptureLocalVariable;

            public void Run(int input)
            {
                int j = 0;
                updateCaptureLocalVariable = x =>
                {
                    j = x;
                    bool result = j > input;
                    Console.WriteLine($"{j} is greater then {input} : {result}");
                };
                isEqualToCaptureLocalVariable = x => x == j;
                Console.WriteLine($"Local variable before lambda invocation : {j}");

                updateCaptureLocalVariable(10);
                Console.WriteLine($"Local variable after lambda invocation : {j}");
            }
        }
    }
}
