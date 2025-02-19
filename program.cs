using System;

namespace MyApplication
{
    class Program
    {

        static void Main(string[] args)
        {

        repeat3:

            PrintOperation();

            int action; //= Convert.ToInt32(Console.ReadLine());
            string input3 = Console.ReadLine();
            int action1;

            if (Int32.TryParse(input3, out action) == false)
            {
                Console.WriteLine("Choose a number between 1 and 4");
                goto repeat3;
            }



            //if (int.TryParse(Console.ReadLine(), out action) && action >= 1 && action <= 4)
            //    break;

            //Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
        

            //if (action > 4)
            //{
            //    Console.WriteLine("Choose a number between 1 and 4");
            //    goto repeat3;
            //}


            if (action < 1 || action > 4)
            {
                Console.WriteLine("INVALID");
                Console.WriteLine("Choose a number between 1 and 4");
                goto repeat3;
            }

        repeat1:

            Console.WriteLine("Enter first number");
            string input1 = Console.ReadLine();
            int n1;

            if (Int32.TryParse(input1, out n1) == false)
            {
                Console.WriteLine("Invalid Number" + " " + input1);
                goto repeat1;
            }




        //int n1;
        //while (true)
        //{
        //    Console.WriteLine("Enter first number");

        //        if (int.TryParse(input, out action) && action >= 1 && action <= 4)
        //            break;

        //        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
        //    }

        //}

        repeat2:

            Console.WriteLine("Enter second number");
            string input2 = Console.ReadLine();
            int n2;

            if (Int32.TryParse(input2, out n2) == false)
            {
                Console.WriteLine("Invalid Number" + " " + input2);
                goto repeat2;
            }

            Calculator calc = new Calculator("Amman");







            int result = 0;
            switch (action)
            {
                case 1:
                    result = calc.Addition(n1, n2);
                    break;
                case 2:
                    result = calc.Subtraction(n1, n2);
                    break;
                case 3:
                    result = calc.Multiplication(n1, n2);
                    break;
                case 4:

                    
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        return;
                    }
                    result = calc.Division(n1, n2);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }

            Console.WriteLine("Answer = " + result);
            goto repeat3;
        }

        static void PrintOperation()
        {
            Console.WriteLine("--------------------------------------------------Choose an operation--------------------------------------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
        }
    }
}
