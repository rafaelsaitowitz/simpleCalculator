using System;

namespace brafk
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Do you want to Add, Subtract, Multiply, or Divide?");
            string operation = Console.ReadLine();
            
            if (operation == "Add")
            {
                double a1;
                double a2;

                Console.WriteLine("Input a number: ");
                a1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input a second number: ");
                a2 = Convert.ToDouble(Console.ReadLine());

                double aResult = a1 + a2;
                Console.WriteLine("The result is " + aResult);

                Console.WriteLine("Would you like to continue?");
                string aAnswer = Console.ReadLine();

                if (aAnswer == "yes")
                {
                    Console.WriteLine("Insert the number you want to add onto " + aResult);
                    double a3 = Convert.ToDouble(Console.ReadLine());
                    double aResult1 = aResult + a3;
                    Console.WriteLine("The result is " + aResult1);
                }
                else if (aAnswer == "no")
                {
                    Console.WriteLine("Please close the program");
                }
                else
                {
                    Console.WriteLine("Invalid Answer. Restart the program");
                }
            }
            else if (operation == "Subtract")
            {
                double s1;
                double s2;

                Console.WriteLine("Input a number: ");
                s1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input a second number: ");
                s2 = Convert.ToDouble(Console.ReadLine());

                double sResult = s1 - s2;
                Console.WriteLine("The result is " + sResult);

                Console.WriteLine("Would you like to continue?");
                string sAnswer = Console.ReadLine();

                if (sAnswer == "yes")
                {
                    Console.WriteLine("Insert the number you want to subtract " + sResult + " by");
                    double s3 = Convert.ToDouble(Console.ReadLine());

                    double aResult1 = sResult - s3;
                    Console.WriteLine("The result is " + aResult1);
                }
                else if (sAnswer == "no")
                {
                    Console.WriteLine("Please close the program");
                }
                else
                {
                    Console.WriteLine("Invalid Answer. Restart the program");
                }
            }
            else if (operation == "Multiply")
            {
                double m1;
                double m2;

                Console.Write("Input a number: ");
                m1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input a second number: ");
                m2 = Convert.ToDouble(Console.ReadLine());

                double mResult = m1 * m2;
                Console.WriteLine("The result is " + mResult);

                Console.WriteLine("Would you like to continue?");
                string mAnswer = Console.ReadLine();

                if (mAnswer == "yes")
                {
                    Console.WriteLine("Insert the number you want to multiply " + mResult + " by");
                    double m3 = Convert.ToDouble(Console.ReadLine());

                    double mResult1 = mResult * m3;
                    Console.WriteLine("The result is " + mResult1);
                }
                else if (mAnswer == "no")
                {
                    Console.WriteLine("Please close the program");
                }
                else
                {
                    Console.WriteLine("Invalid Answer. Restart the program");
                }
            }
            else if (operation == "Divide")
            {
                double d1;
                double d2;

                Console.Write("Input a number: ");
                d1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input a second number: ");
                d2 = Convert.ToDouble(Console.ReadLine());

                double dResult = d1 / d2;
                Console.WriteLine("The result is " + dResult);

                Console.WriteLine("Would you like to continue?");
                string dAnswer = Console.ReadLine();

                if (dAnswer == "yes")
                {
                    Console.WriteLine("Insert the number you want to divide " + dResult + " by");
                    double d3 = Convert.ToDouble(Console.ReadLine());

                    double dResult1 = dResult / d3;
                    Console.WriteLine("The result is " + dResult1);
                }
                else if (dAnswer == "no")
                {
                    Console.WriteLine("Please close the program");
                }
                else
                {
                    Console.WriteLine("Invalid Answer. Restart the program");
                }
            }
            else
            {
                Console.WriteLine("Please restart the program and enter 'Add', 'Subtract', 'Multiply', or 'Divide'");
            }
        }
    }
}

