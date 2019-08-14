using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_SAyı
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Bir sayı girin: ");
                Console.ForegroundColor = ConsoleColor.Gray;

                int _Sayi = Convert.ToInt32(Console.ReadLine());

                if (_Sayi <= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Girdiğiniz sayı 1'den büyük olmalıdır!");
                }
                else
                {
                    List<int> TamBolenler = new List<int>();

                    for (int i = 2; i < _Sayi; i++)
                    {
                        TamBolenler.Add(i);
                    }

                    for (int i = 2; i < _Sayi; i++)
                    {
                        if (_Sayi % i != 0)
                        {
                            TamBolenler.Remove(i);
                        }
                    }

                    if (TamBolenler.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Girdiğiniz Sayı Asal");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Girdiğiniz Sayı Asal Değil");
                        Console.Write("Bölenleri : ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        for (int i = 0; i < TamBolenler.Count; i++)
                        {
                            if (i != TamBolenler.Count - 1)
                            {
                                Console.Write(TamBolenler[i].ToString() + " - ");
                            }
                            else
                            {
                                Console.WriteLine(TamBolenler[i].ToString());
                            }
                        }
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

            }
        }
    }
}
