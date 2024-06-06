using System;

delegate int RandomValueDelegate();

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        
        // Створення масиву делегатів
        RandomValueDelegate[] delegates = new RandomValueDelegate[5];
        for (int i = 0; i < delegates.Length; i++)
        {
            // Ініціалізація кожного делегата анонімним методом, який повертає випадкове значення
            delegates[i] = () => random.Next(1, 101); // Випадкове значення від 1 до 100
        }

        // Анонімний метод для обчислення середнього арифметичного
        Func<RandomValueDelegate[], double> calculateAverage = delegate (RandomValueDelegate[] delArray)
        {
            double sum = 0;
            foreach (var del in delArray)
            {
                sum += del();
            }

            return sum / delArray.Length;
        };

        // Виклик анонімного методу та виведення результату
        double average = calculateAverage(delegates);
        Console.WriteLine($"The average value is: {average}");
        Console.ReadKey();
    }
}