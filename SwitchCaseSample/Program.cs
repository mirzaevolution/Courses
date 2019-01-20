using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("       My Apps v1.0");
            Console.WriteLine("***************************");
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Lihat Data");
            Console.WriteLine("2. Input Data");
            Console.WriteLine("3. Update Data");
            Console.WriteLine("4. Hapus Data");
            Console.WriteLine("5. Keluar");
            Console.Write("\nInput menu [1-5]: ");
            int menu = 0;
            menu = int.Parse(Console.ReadLine());
            switch(menu)
            {
                case 1:
                    {
                        Console.WriteLine("\nAnda membuka menu [Lihat Data]");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nAnda membuka menu [Input Data]");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nAnda membuka menu [Update Data]");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\nAnda membuka menu [Hapus Data]");
                        break;
                    }
                case 5:
                    {
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Menu yang anda masukkan salah!");
                        break;
                    }

            }

            Console.WriteLine("Tekan [enter] untuk keluar program");
            Console.ReadLine();
        }
    }
}
