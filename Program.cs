
using Structures;

internal class Program
{
    public static int Sum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    public static int Mult(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
    
    private static void Main(string[] args)
    {
        int[] arr = new int[4] { 1, 3, 4, 5 };
        CalculateDelegate calculateDelegate = Sum;
        CalculateDelegate calculateDelegate1 = new CalculateDelegate(Mult);
        Vector vector1 = new(arr, calculateDelegate1);

        Console.WriteLine(vector1.GetStringArr());
    }
}