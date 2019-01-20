using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 44;
            //operasi ternari
            //(kondisi) ? (hasil true) : (hasil false)
            //tipe data hasil true harus sama dengan tipe data hasil false
            string resultA = a > b ? "A lebih besar dari B" : "B lebih besar dari A";
            string resultAGanjilGenap = a % 2 == 0 ? "A bilangan genap" : "A bilangan ganjil";
            Console.WriteLine(resultA);
            Console.WriteLine(resultAGanjilGenap);
            Console.ReadLine();
        }
    }
}
