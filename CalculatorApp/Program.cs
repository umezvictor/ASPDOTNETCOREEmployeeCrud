using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter action to be performed");
            Console.WriteLine("press 1 for addition");
            Console.WriteLine("press 2 for subtraction");
            Console.WriteLine("press 3 for multiplication");
            Console.WriteLine("press 4 for division");

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ente 1st input");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd input");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            switch (action)
            {
                case 1:
                    {
                        result = Addition(input1, input2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input1, input2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input1, input2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input1, input2);
                        break;
                    }
                default:
                    
                        Console.WriteLine("wrong action, try again");
                        break;        
            }

            Console.WriteLine("this result is {0}", result);
            Console.ReadKey();
        }

        //method for Addition
        public static int Addition(int input1, int input2)
        {
            int result = input1 + input2;
            return result;
        }

        //method for Subtraction
        public static int Subtraction(int input1, int input2)
        {
            int result = input1 - input2;
            return result;
        }

        //method for Multiplication
        public static int Multiplication(int input1, int input2)
        {
            int result = input1 * input2;
            return result;
        }

        //method for Division
        public static int Division(int input1, int input2)
        {
            int result = input1 / input2;
            return result;
        }
    }
}
