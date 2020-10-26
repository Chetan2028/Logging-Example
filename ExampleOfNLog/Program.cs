using System;

namespace ExampleOfNLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            AddNumbers addNumbers = new AddNumbers();
            int sum = addNumbers.Add(firstNumber, secondNumber);
            Console.WriteLine("sum is : " + sum);
        }
    }
}
