/* Array 1D atau 1 Dimensi atau Linear */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIntroduction
{
    class Program
    {
        static void Array1()
        {
            //tipe_data[] nama_variable = new tipe_data[size_array]
            // - index array dimulai dari 0
            // - kita tidak bisa mengakses array kurang dari/lebih dari ukurannya
            // - apabila kita mengakses array kurang dari/lebih dari indexnya,
            //   maka akan terjadi error/exception dengan nama 'IndexOutOfRangeException'

            //manual assignment


            //initialize array part 1
            int[] myNumbers = new int[5];

            //assignment array (manual)
            myNumbers[0] = 100;
            myNumbers[1] = 200;
            myNumbers[2] = 300;
            myNumbers[3] = 400;
            myNumbers[4] = 500;

            int length = myNumbers.Length; //5
            Console.WriteLine("Panjang array: {0}", length);

            //mengetahu isi array ada 2
            //1. Manual index reference
            //2. Iterasi dengan foreach/for/while/do-while

            //1. Manual Index Reference
            Console.WriteLine("Index Ke 1: {0}", myNumbers[0]);
            Console.WriteLine("Index Ke 3: {0}", myNumbers[2]);
            Console.WriteLine("Index Ke 5: {0}", myNumbers[4]);

            Console.WriteLine();
            
            //2. Iterasi
            //for
            for(int index = 0; index < length; index++)
            {
                Console.WriteLine("Index ke {0}: {1}", index + 1, myNumbers[index]);
            }

            Console.WriteLine();


            int i = 1;
            //foreach
            foreach (int item in myNumbers)
            {
                Console.WriteLine("Index ke {0}: {1}",i++,item);

            }

        }
        static void Array2()
        {
            //tipe_data[] nama_variable = new tipe_data[size_array]
            // - index array dimulai dari 0
            // - kita tidak bisa mengakses array kurang dari/lebih dari ukurannya
            // - apabila kita mengakses array kurang dari/lebih dari indexnya,
            //   maka akan terjadi error/exception dengan nama 'IndexOutOfRangeException'

            //direct assignment

            //string[] names = new string[4] 
            //{
            //    "Mirza Ghulam Rasyid",
            //    "Rara Anjani",
            //    "Michael Hawk",
            //    "Herry"
            //};

            string[] names = new string[]
            {
                "Mirza Ghulam Rasyid",
                "Rara Anjani",
                "Michael Hawk",
                "Herry"
            };
            Console.WriteLine("Isi dari array `names`: {0}", names.Length);
            Console.WriteLine();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void Array3()
        {
            //initialize array part 1
            int[] myNumbers = new int[5];

            //assignment array (manual)
            myNumbers[0] = 100;
            myNumbers[1] = 200;
            myNumbers[2] = 300;
            myNumbers[3] = 400;
            myNumbers[4] = 500;

            //error karena set value diluar jangkauan array
            try
            {
                //error
                myNumbers[10] = 12;

            }
            catch(IndexOutOfRangeException error)
            {
                Console.WriteLine("Message: {0}", error.Message);
                Console.WriteLine("Stacktrace: {0}", error.StackTrace);
            }


            //error karena get value diluar jangkauan array
            try
            {
                //error
                Console.WriteLine("Array index ke 100: {0}", myNumbers[100]);

            }
            catch (IndexOutOfRangeException error)
            {
                Console.WriteLine("Message: {0}", error.Message);
                Console.WriteLine("Stacktrace: {0}", error.StackTrace);
            }
        }
        static void HitungTotalData()
        {
            int[] array = new int[]
            {
                 13,
                 2315,
                 121,
                 1312,
                 923,
                 10
                 -123,
                 -89,
                 788
            };
            int sum = 0;

            foreach(int item in array)
            {
                sum += item;
            }
            Console.WriteLine("Sum of array: {0}", sum);
        }
        static void ArrayFromInputUser()
        {
            int n;
            Console.Write("Masukkan total data: ");

            //validasi untuk mengecek nilai yang di-input user apakah integer atau bukan

            if(int.TryParse(Console.ReadLine(), out n))
            {
                string[] names = new string[n];
                Console.WriteLine("\nMasukkan nama user.");
                for(int i = 0; i < n; i++)
                {
                    Console.Write("Masukkan nama ke - {0}: ", i + 1);
                    string name = Console.ReadLine();
                    names[i] = name;
                }
                Console.WriteLine("\nNama yang anda masukkan:");
                foreach(string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            else
            {
                Console.WriteLine("Masukkan nilai integer");
            }
        }
        static void SortArray()
        {
            int[] numbers = new int[]
            {
                1231,
                -3242,
                9,
                778,
                3934,
                234,
                7345
            };
            string[] names = new string[]
            {
                "Mirza Ghulam Rasyid",
                "Rara Anjani",
                "Michael Hawk"
            };
            Array.Sort(numbers);
            System.Array.Sort(names);

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void Main(string[] args)
        {
            //Array1();
            //Array2();
            //Array3();
            //HitungTotalData();
            //ArrayFromInputUser();
            SortArray();
            Console.ReadLine();
        }
    }
}
