using System;

namespace TestCalculator
{
    class basic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number :");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator : ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter the second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;
            
            if(op == "+")
            {
                result = num1+num2;
                Console.WriteLine(result);
            } else if(op == "-")
            {
                result = num1-num2;
                Console.WriteLine(result);

            } else if(op=="*")
            {
                result = num1*num2;
                Console.WriteLine(result);
            } else if(op == "/")
            {
                result = num1/num2;
                Console.WriteLine(result);

            } else{
                Console.WriteLine("Wrong choice");
                
            }


        }
    }
}
