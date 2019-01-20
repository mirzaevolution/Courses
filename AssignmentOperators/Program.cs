using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOperators
{
    class Program
    {
        static void Sample1()
        {
            int a = 2;
            a = a + 1; //3
            Console.WriteLine(a);
            a += 1; //4; -> shortcut => a = a+1
            Console.WriteLine(a);
            a++; //5; -> shortcut => a = a+1 tidak bisa a = a + n dimana (n>1)
            Console.WriteLine(a);

            //shortuct variable++/variable-- hanya bisa diterapkan
            //untuk operator + atau operator - saja
            //ex: a++ atau a--;

        }
        static void Sample2()
        {
            int a = 2;
            a = a * 2; //4
            Console.WriteLine(a);
            a *= 2; //8
            Console.WriteLine(a);
        }
        static void Sample3()
        {
            int a = 10;
            a--;
            Console.WriteLine(a);
        }
        static void PreAssignment()
        {
            int val1 = 12;
            int val2 = 12;
            //Console.WriteLine(val1++);
            //Console.WriteLine(++val2);

            int b = val1++;
            //||
            //\/

            //int b = val1;
            //val1 = val1 + 1;
            

            
            int c = ++val2;
            //||
            //\/
            //val1++;
            //int b = val1;



            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            //Sample1();
            //Sample2();
            //Sample3();
            PreAssignment();
            Console.ReadLine();
        }
    }
}
