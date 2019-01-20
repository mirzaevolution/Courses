using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingStatements
{
    class Program
    {

        #region For
        static void ForStatement()
        {
            //bentuk 1
            //for(int loop = 1; loop <= 10; loop++)
            //{
            //    Console.WriteLine(loop);
            //}

            //bentuk 2
            //for (int loop = 1; loop <= 10; loop+=1)
            //{
            //    Console.WriteLine(loop);
            //}

            //bentuk 3
            //for (int loop = 1; loop <= 10; loop+=2)
            //{
            //    Console.WriteLine(loop);
            //}

            //bentuk 4
            //for (int loop = 1; loop <= 10;)
            //{
            //    Console.WriteLine(loop);
            //    loop++;
            //}

            //bentuk 5
            //for (int loop = 1; loop <= 10;)
            //{
            //    loop++;
            //    Console.WriteLine(loop);
            //}

            //bentuk 6
            //for (int loop = 1; loop <= 10;)
            //{
            //    Console.WriteLine(loop);
            //    ++loop;
            //}

            //bentuk 7
            //for (int loop = 1; loop <= 10;)
            //{
            //    Console.WriteLine(loop++);
            //}

            //bentuk 8
            //for (int loop = 1; loop <= 10;)
            //{
            //    Console.WriteLine(++loop);
            //}

            //bentuk 9
            //int i = 1;
            //for (; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //bentuk 10
            //infinite looping
            //for(;;)
            //{
            //    Console.WriteLine("Boom!!!");
            //}

            //bentuk 11
            //infinite looping 2
            //for(int loop=10;loop>=10;)
            //{
            //    Console.WriteLine("Boom!");
            //}

            //break statement
            //fungsi: untuk menghentikan perulangan
            //dapat diterapkan untuk statement [for],[while],[do-while]
            //for(int i = 1; i <= 10; i++)
            //{
            //    if (i == 6)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //continue statement
            //fungsi: untuk melompat ke perulangan berikutnya (skip)
            //dapat diterapkan untuk statement [for],[while],[do-while]
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 6)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
        }
        static void ForExample()
        {
            //2,4,8,16,32,64,128,256,512,1024,2048,4096
            for(int i = 1; i <= 12; i++)
            {
                double value = Math.Pow(2,i);
                Console.Write("{0} ", value);
            }
        }
        #endregion

        #region while
        static void WhileStatement()
        {
            //bentuk 1
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //bentuk 2
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i++);
            //}

            //bentuk 3
            //infinite looping
            while (true)
            {
                Console.WriteLine("Boom!");
            }
        }
        #endregion

        #region do-while
        static void DoWhileStatement()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }
        #endregion

        #region while vs do-while
        static void WhileVsDoWhile()
        {
            int i = 10;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 10;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);
        }
        #endregion

        static void Main(string[] args)
        {
            //ForStatement();
            //ForExample();
            //WhileStatement();
            //DoWhileStatement();
            WhileVsDoWhile();
            Console.ReadLine();
        }
    }
}
