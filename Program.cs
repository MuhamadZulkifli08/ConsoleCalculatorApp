using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi calculator";

            Console.WriteLine("Daftar Menu");
            Console.WriteLine("1.Penjumlahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");

            Console.Write("Pilih : ");
            int menu = Convert.ToInt32(Console.ReadLine());

            if (menu > 4 || menu < 0)
            {
                Console.WriteLine("eror");

            }
            else
            {

                switch (menu)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Penjumlahan");
                            Console.Write("input a:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("input b:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penjumlahan(a, b));
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Pengurangan");
                            Console.Write("input a:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("input b:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Perkalian");
                            Console.Write("input a:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("input b:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Pembagian");
                            Console.Write("input a:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("input b:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                            break;
                        }
                }
            }
        }

        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }

    }
}