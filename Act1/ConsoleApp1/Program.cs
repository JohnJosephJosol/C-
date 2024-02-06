using System;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace Act1
{
    public class Math
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("total: " + (num1 + num2) + "\n");
        }
        public void Sub(int num1, int num2)
        {
            Console.WriteLine("total: " + (num1 - num2) + "\n");
        }
        public void Multiply(int num1, int num2)
        {
            Console.WriteLine("total: " + (num1 * num2) + "\n");
        }
        public void Divide(int num1, int num2)
        {
            Console.WriteLine("total: " + (num1 / num2) + "\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            int num1, num2;

            Console.WriteLine("Enter two numbers to add: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            math.Add(num1, num2);

            Console.WriteLine("Enter two numbers to subtract: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            math.Sub(num1, num2);

            Console.WriteLine("Enter two numbers to multiply: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            math.Multiply(num1, num2);

            Console.WriteLine("Enter two numbers to divide: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            math.Divide(num1, num2);
        }
    }

}

/*public int add(int num1, int num2) { 
    ReturnTypeEncoder num1 + num2;
}*/