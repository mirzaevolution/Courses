using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        //penambahan dengan operator +
        static void Addition()      
        {
            int number1 = 123;
            int number2 = 321;
            int sum = number1 + number2; //hasil   hfrey35u3
            Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
        }
        //pengurangan dengan operator -
        static void Subtraction()
        {
            int number1 = 333;
            int number2 = 120;
            int result1 = number1 - number2; //hasil positif
            int result2 = number2 - number1;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, result1);
            Console.WriteLine("{0} + {1} = {2}", number2, number1, result2);

        }
        //perkalian dengan operator *
        static void Multiplication()
        {
            int number1 = 23;
            int number2 = 33;
            int result = number1 * number2;
            Console.WriteLine("{0} * {1} = {2}", number1, number2, result);
        }
        //pembagian dengan operator /
        static void Division1()
        {
            int number1 = 100;
            int number2 = 2;
            int result = number1 / number2;
            Console.WriteLine("{0} / {1} = {2}", number1,number2,result);
        }
        //pembagian dengan nilai 0 (error)
        static void Division2()
        {
            int number1 = 100;
            int number2 = 0;
            int result = number1 / number2;
            Console.WriteLine("{0} / {1} = {2}", number1,number2, result);
        }
        //pembagian dengan nilai 0 (error namun error dapat di tangkap)
        static void DivisionSafe()
        {
            int number1 = 100;
            int number2 = 0;
            try
            {
                int result = number1 / number2;
                Console.WriteLine("{0} / {1} = {2}", number1, number2, result);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tidak dapat membagi bilangan dengan 0!");
            }
        }
        //operasi modulus dengan operator %
        static void Modulus()
        {
            int number1 = 12;
            int number2 = 2;
            int number3 = 5;
            int result1 = number1 % number2;
            int result2 = number1 % number3;
            Console.WriteLine("{0} % {1} = {2}", number1, number2, result1);
            Console.WriteLine("{0} % {1} = {2}", number1, number3, result2);
        }
        static void Main(string[] args)
        {
            Addition();
            Subtraction();
            Multiplication();
            Division1();
            Division2();
            DivisionSafe();
            Modulus();
            Console.ReadLine();
        }
    }
}
