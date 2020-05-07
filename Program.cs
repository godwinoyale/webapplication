using System;
using System.Text;
using System.Collections;
using System.Data;

namespace webApplication
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Write("\n");
        Console.Write("Check and compare the square root of any two numbers : ");
        Console.Write("\n");
        Console.Write("Input first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        double SqrtNumber = Math.Sqrt(num1);
        Console.Write("Input second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        double SqrtNumber2 = Math.Sqrt(num2); 
            if (num1 > num2){
                Console.WriteLine("The number " + num1 + " with square root " + SqrtNumber + " has a higher square root than the number " + num2 + " with square root "+ SqrtNumber2 + ".");

            }else if(num2 > num1){
                Console.WriteLine("The number " + num2 + " with square root " + SqrtNumber2 + " has a higher square root than the number " + num1 + " with square root "+ SqrtNumber +".");

            }
            if (num1 == num2){
                Console.WriteLine("The first number " + num1 + " has the same square root with the second number " + num2 + " which are all " + SqrtNumber + " as their square root.");
                Console.WriteLine("Enter different values.");
                
            }
       
        {
            
        }
        }
    }
}
