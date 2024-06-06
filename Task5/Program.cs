class Program
{
    static void Main(string[] ard)
    {
        Func<int, int, int, double> calculateAverage = delegate(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3) / 3.0;
        };
        Console.WriteLine("Please input the first integer:");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Please input the second integer:");
        int num2 = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Please input the third integer:");
        int num3 = Int32.Parse(Console.ReadLine());

        double average = calculateAverage(num1, num2, num3);
        Console.WriteLine($"The average value is: {average}");
        
        Console.ReadKey();
    }
}