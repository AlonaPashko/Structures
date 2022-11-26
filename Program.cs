
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
        Console.WriteLine("Sum = " + sum);
        return sum;
    }
    public static int Mult(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        Console.WriteLine("Product = " + product);
        return product;
    }
    public static int AvgSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Average = " + sum / array.Length);
        return sum / array.Length;
    }
    public static void Message(string name)
    {
        Console.WriteLine($"Same surname is group named {name}!");
    }
    public static void MessageForStrong(string name)
    {
        Console.WriteLine($"Same surname in company named {name} was not added!");
    }
    
    private static void Main(string[] args)
    {
        //int[] arr = new int[4] { 1, 3, 4, 5 };
        //CalculateDelegate calculateDelegate = Sum;
        ////CalculateDelegate calculateDelegate1 = new CalculateDelegate(Mult);
        ////calculateDelegate += Mult;

        //Vector vector1 = new(arr, calculateDelegate);
        //vector1.CalculateDelegateProperty += Mult;
        //Console.WriteLine(vector1.Result);
        //vector1.Method();
        //Console.WriteLine("----------------");
        //vector1.CalculateDelegateProperty += AvgSum;
        //Console.WriteLine(vector1.GetStringArr());

        //List<Person> persons = new List<Person>() { new("per1"), new("per2"), new("per3") };
        Peoples peoples = new Peoples();
        peoples.SameSurname += Message;
        peoples.Guider = "per1";
        peoples.Add(new("Name1", "per1"));
        peoples.Add(new("Name2", "per2"));
        Console.WriteLine(peoples);

        Peoples company = new StrongCompany();
        company.Guider = "per2";
        company.SameSurname += MessageForStrong;
        company.Add(new("Name2", "per2"));
        company.Add(new("Name3", "per3"));
        Console.WriteLine(company);
    }
}