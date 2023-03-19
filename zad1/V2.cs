using System;
using System.Numerics;

 namespace Zad1{
    class V2{
    public decimal sin_taylor_tyl(BigInteger ilosc_wyrazow, double wartosc_do_obliczenia, int[] wartosci_pochodnych){       
        decimal rezultat = 0;
        decimal wyraz_ciagu;
        double radiany = (wartosc_do_obliczenia ) * Program.pi/(double)180.0;
        for(int i = (int)ilosc_wyrazow ; i > 0 ; i--){
            int wartosc_pochodnej = wartosci_pochodnych[ i % wartosci_pochodnych.Length ];
            wyraz_ciagu = (decimal)(wartosc_pochodnej / Program.silnia(i) * (Program.potegi((radiany), i)));
            rezultat = rezultat + wyraz_ciagu;
        }
        return rezultat;
    }
    }
 }