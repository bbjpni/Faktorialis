using System;
using System.Collections.Generic;

namespace fAKi
{
    class Program
    {
        static int faki(int szam)
        {
            if (szam < 0)
            {
                throw new ArgumentException("A paraméter nem lehet negatív");
            }
            else if(szam == 0)
            {
                return 1;
            }
            else
            {
                int back = 1;
                for (int i = 0; i < szam; i++)
                {
                    back *= (i + 1);
                }
                return back;
            }
            
        }

        static int rekurzivFaki(int szam)
        {
            if (szam < 0)
            {
                throw new ArgumentException("A paraméter nem lehet negatív");
            }
            else if (szam == 0)
            {
                return 1;
            }
            else
            {
                return szam * rekurzivFaki(szam-1);
            }

        }

        static double hatvany(double alap, int kitevo)
        {
            double back = 1.0;
            if (alap == 0)
            {
                throw new ArgumentException("A nulla nem értelmezhető alapként");
            }
            else if (kitevo == 0)
            {
                return 1;
            }
            else
            {
                alap = kitevo < 0 ? 1.0 / alap : alap;
                kitevo = kitevo < 0 ? -1 * kitevo : kitevo;
                for (int i = 0; i < kitevo; i++)
                {
                    back *= alap;
                }

            }
            
            return back;
        }

        static double rekurzivHatvany(double alap, int kitevo)
        {
            if (alap == 0)
            {
                throw new ArgumentException("A nulla nem értelmezhető alapként");
            }
            else if (kitevo == 0)
            {
                return 1;
            }
            else
            {
                alap = kitevo < 0 ? 1.0 / alap : alap;
                kitevo = kitevo < 0 ? -1 * kitevo : kitevo;
                return alap * rekurzivHatvany(alap,kitevo-1);
            }
        }

        static int rekurzivBin(int n, int k)
        {
            if (k == 0 || n == k)
            {
                throw new ArgumentException("hiba");
            }
            else if (k > 0 && k < n)
            {
                return rekurzivBin(n - 1, k - 1) + rekurzivBin(n - 1, k); ;
            }
            else
            {
                return 1;
            }
        }

        static int rekurzivOsszeg(int[] tomb)
        {
            if (tomb.Length == 0)
            {
                return 0;
            }
            else
            {
                List<int> temp = new List<int>(tomb);
                int szam = temp[0];
                temp.Remove(temp[0]);
                tomb = temp.ToArray();
                return szam + rekurzivOsszeg(tomb);
            }
        }

        static string rekurzivForditas(string szo)
        {
            if (szo.Length == 0)
            {
                return szo;
            }
            else
            {
                string szo2 = "";
                for (int i = 0; i < szo.Length - 1; i++)
                {
                    szo2 += szo[i];
                }
                szo2 = szo;
                return szo[szo.Length - 1] + rekurzivForditas(szo2);
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(faki(5));
            Console.WriteLine(rekurzivFaki(5));
            Console.WriteLine(hatvany(-2, -2));
            Console.WriteLine(rekurzivHatvany(5, -8));
            Console.WriteLine(rekurzivBin(8,9));
            Console.WriteLine(rekurzivOsszeg(new int[] {5, 4, 8, 12, 20, 9 }));
            Console.WriteLine(rekurzivForditas("GIVENCHY"));
            Console.ReadKey();
        }
    }
}
