class Calculator
{
    public static Func<double, double, double> Add = (num1, num2)
        => num1 + num2;
    
    public static Func<double, double, double> Sub = (num1, num2)
        => num1 - num2;

    public static Func<double, double, double> Mul = (num1, num2)
        => num1 * num2;
    
    public static Func<double, double, double> Div = (num1, num2)
        => num2 != 0 ? num1 / num2 
            : throw new ArgumentException("Division by 0 is forbidden");

}

class Program
{
    public static void Main(string[] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("Please input number 1");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input number 2");
            double num2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please input operation (Add, Sub, Mul, Div):");
            string operation = Console.ReadLine();

            if (operation.ToLower() == "exit")
            {
                keepRunning = false;
                break;
            }

            try
            {
                double result = operation switch
                {
                    "Add" => Calculator.Add(num1, num2),
                    "Sub" => Calculator.Sub(num1, num2),
                    "Mul" => Calculator.Mul(num1, num2),
                    "Div" => Calculator.Div(num1, num2),
                    _=> throw new ArgumentException("Invalid operation")
                };
                Console.WriteLine($"The result of {operation} is: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        
    }

}