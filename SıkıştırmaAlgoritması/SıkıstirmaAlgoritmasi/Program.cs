using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıkıstirmaAlgoritmasi
{
    class Program
    {
        static int toplamBit = 0;
        static void Main(string[] args)
        {

            int[,] dizi = new int[8, 8];
            int[] dizi3 = new int[64];
            int[] dizi4 = new int[64];
            Random rnd = new Random();

            Console.WriteLine("Elemanları Rastgele Üretilen 8*8 lik matris");
            Console.WriteLine();

            for (int i=0; i<=dizi.GetUpperBound(0); i++)
            {
                for(int j=0; j <=dizi.GetUpperBound(1); j++)
                {
                    
                    int sayi = rnd.Next(0, 100);
                    dizi[i, j] = sayi;
                    Console.Write(" {0,3}", dizi[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************");
            Console.WriteLine("Matris Elemanları Arasındaki Farklar");
            Console.WriteLine();


            int m = 0;
                for (int i = 0; i <=dizi.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= dizi.GetUpperBound(1); j++)
                    {
                        dizi3[m] = dizi[i, j];
                        
                        //if (m < 64)
                        //{
                        //    Console.Write(dizi3[m] +" ");
                        //}
                        //else
                        //{
                        //    break;
                        //}
                        m++;
                    }
                }
       
            Console.WriteLine();
            int fark;
            dizi4[0] = dizi3[0];
            
            for (int i = 0; i < dizi4.Length-1; i++)
            {
                fark = dizi3[i + 1] - dizi3[i];
                dizi4[i+1] = fark;
                
            }
            int num = 0;
            foreach (int  eleman in dizi4)
            {
                if (num % 8 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write( "{0,3} ", eleman);
                num++;
            }
            {

            }
            Console.WriteLine();
            Console.WriteLine("***********************************");

            Console.WriteLine("Her Elemanı Yazabilmek  İçin Gerekli Bit Sayısı");
            Console.WriteLine();
            foreach (int elemanlar in dizi4)
            {
                {
                    
                    int bit = 0;
                    int deger = 1;

                    for (int k = 1; ;)
                    {
                        deger *= 2;
                        if (deger >= Math.Abs(elemanlar))
                        {
                            bit = k + 1;
                            toplamBit += bit;
                            break;
                            
                        }
                        else
                        {
                            k++;
                        }


                    }
                    Console.Write(bit + " " );
                }
                
            }
            Console.WriteLine("\nToplam Gerekli Bit Sayısı:" + toplamBit);



            Console.Read();
        }
        
    }
}
