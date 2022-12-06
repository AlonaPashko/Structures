
using Structures;
using System.Security.Cryptography.X509Certificates;
using System;
using static Structures.VariableScopeWithLambdas;

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
    static void FunctionWriting(int i)
    {
        Console.WriteLine("Function");
    }
    static void Generals(int i)
    {
        Console.WriteLine("General function");
    }
    private static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    private static string UppercaseString(string inputString)
    {
        return inputString.ToUpper();
    }

    private static void Main(string[] args)
    {
        //int[] arr = new int[4] { 1, 3, 4, 5 };
        //CalculateDelegate calculateDelegate = Sum;
        //CalculateDelegate calculateDelegate1 = new CalculateDelegate(Mult);
        //calculateDelegate += Mult;

        //Vector vector1 = new(arr, calculateDelegate);
        //vector1.CalculateDelegateProperty += Mult;
        //Console.WriteLine(vector1.Result);
        //vector1.Method();
        //Console.WriteLine("----------------");
        //vector1.CalculateDelegateProperty += AvgSum;
        //Console.WriteLine(vector1.GetStringArr());

        ////List<Person> persons = new List<Person>() { new("per1"), new("per2"), new("per3") };
        //Peoples peoples = new Peoples();
        //peoples.SameSurname += Message;
        //peoples.Guider = "per1";
        //peoples.Add(new("Name1", "per1"));
        //peoples.Add(new("Name2", "per2"));
        //Console.WriteLine(peoples);

        //Peoples company = new StrongCompany();
        //company.Guider = "per2";
        //company.SameSurname += MessageForStrong;
        //company.Add(new("Name2", "per2"));
        //company.Add(new("Name3", "per3"));
        //Console.WriteLine(company);

        Demo.Start();

        ExampleDelegate exampleDelegate = new ExampleDelegate(FunctionWriting);
        exampleDelegate += Generals;
        exampleDelegate(9);

        Account account1 = new Account(200, 6);
        account1.RegisterHandler(new Account.AccountStateHandlerDelegate(ShowMessage));
        account1.Withdraw(100);
        account1.Withdraw(150);

        //var choose = [Example(2)][Example(3)] object (bool b) => b ? 1 : "two";
        //var sum = ([Example(1)] int a, [Example(2), Example(3)] int b) => a + b;
        //var inc = [return Example(1)](int s) => s++;

        Console.WriteLine("---------------------");
        var game = new VariableCaptureGame();
        int gameInput = 5;
        game.Run(gameInput);
        int jTry = 10;
        bool result = game.isEqualToCaptureLocalVariable!(jTry);
        Console.WriteLine($"Captured local variable is equal to {jTry} : {result}");
        int anotherJ = 3;
        game.updateCaptureLocalVariable!(anotherJ);
        bool equalToAnother = game.isEqualToCaptureLocalVariable(anotherJ);
        Console.WriteLine($"Another lambda observes a new value of captured variable: {equalToAnother}");


        Console.WriteLine("---------------------");
        ConverteMethod convertMeth = UppercaseString;
        string name1 = "Dakota";
        Console.WriteLine("Using delegate: " + convertMeth(name1));

        Console.WriteLine("---------------------");
        Func<string, string> converteMethod = UppercaseString;
        string name2 = "Dorota";
        Console.WriteLine("Using Func delegate: " + converteMethod(name2));
        Console.WriteLine("---------------------");

        Random rnd = new Random();
        List<HockeyTeam> teams = new List<HockeyTeam>();
        teams.AddRange(new HockeyTeam[] {new HockeyTeam("Detroit Red Wings", 1926), new HockeyTeam("Chicago Blackhawks",1926),
        new HockeyTeam("San Jose Shark", 1991), new HockeyTeam("Montreal Canadians", 1991), new HockeyTeam("St.Louis Blues",1967)});

        int[] years = { 1920, 1930, 1980, 2000 };
        int foundedBeforeYear = years[rnd.Next(0,years.Length)];
        Console.WriteLine("Teams founded before {0}: ", foundedBeforeYear);
        foreach (var team in teams.FindAll(x => x.Founded <= foundedBeforeYear))
        Console.WriteLine("{0} : {1}", team.Name, team.Founded);

    }
}