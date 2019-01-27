using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2Dimensi
{
    class Program
    {
        static void Array2DimensiIntro()
        {
            //Array 2 dimensi bertipe matrix/table.
            //Dengan row/column [row,column]
            


            //cara initialisasi 1
            int[,] data = new int[2, 3];
            //row 0
            data[0, 0] = 1; //row 0, column 0
            data[0, 1] = 2; //row 0, column 1
            data[0, 2] = 3; //row 0, column 2

            //row 1
            data[1, 0] = 4; //row 0, column 0
            data[1, 1] = 5; //row 0, column 1
            data[1, 2] = 6; //row 0, column 2

            //cara inisialisasi 2
            int[,] data2 = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };



            int rowLength = data2.GetLength(0);
            int colLength = data2.GetLength(1);

            for(int rowIndex = 0; rowIndex < rowLength; rowIndex++)
            {
                for(int colIndex=0; colIndex < colLength; colIndex++)
                {
                    Console.Write("{0} ", data2[rowIndex, colIndex]);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Array2DimensiIntro();
            Console.ReadLine();
        }
    }
}
