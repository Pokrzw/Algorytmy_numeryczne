using System;
using System.Numerics;

namespace Zad1{
    class Program{
        static public decimal pi = (decimal)Math.PI;
        static int[] wartosci_dla_180 = new int[4] {0, -1, 0, 1};
        static int[] wartosci_dla_0 = new int[4] {0, 1, 0, -1};

        static public BigInteger silnia(BigInteger n){
            BigInteger result = 1;
            for(BigInteger i = 0; i < n ;i++){
                result = result * (i + 1);
            }
            return result;
        }

        static public decimal potegi(decimal liczba, BigInteger wykladnik){
            decimal wynik = 1;
            for(BigInteger i = 0; i < wykladnik; i++){
                wynik = wynik * liczba;
            }
            return wynik;
        }
        static BigInteger ilosc_wyrazow = 1000000;
        static decimal wartosc_do_obliczenia = 90;
        //wartosc wyrazu podana w stopniach

        static void Main(string[] args){
            V1 v1 = new V1();
            V2 v2 = new V2();
            V3 v3 = new V3();
            V4 v4 = new V4();
            Console.WriteLine(v1.sin_taylor(ilosc_wyrazow, wartosc_do_obliczenia, wartosci_dla_0));
            // Console.WriteLine(v2.sin_taylor_tyl(ilosc_wyrazow, wartosc_do_obliczenia, wartosci_dla_0));
            // Console.WriteLine(v3.suma_od_przodu(ilosc_wyrazow, wartosc_do_obliczenia, wartosci_dla_0));
            // Console.WriteLine(v4.suma_od_tylu(ilosc_wyrazow, wartosc_do_obliczenia, wartosci_dla_0));


        }
    }
}