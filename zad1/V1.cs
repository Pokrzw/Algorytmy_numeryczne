using System;
using System.Numerics;

 namespace Zad1{
    class V1{
    public decimal sin_taylor(BigInteger ilosc_wyrazow, decimal wartosc_do_obliczenia, int[] wartosci_pochodnych){       
        decimal rezultat = 0;
        decimal wyraz_ciagu;
        decimal radiany = (wartosc_do_obliczenia ) * Program.pi/(decimal)180.0;
        for(BigInteger i = 0 ; i < ilosc_wyrazow; i++){
            int wartosc_pochodnej = wartosci_pochodnych[ (int)i % wartosci_pochodnych.Length ];
            wyraz_ciagu = (decimal)((decimal)((BigInteger)wartosc_pochodnej / Program.silnia(i)) * (Program.potegi((radiany), i)));
            rezultat = rezultat + wyraz_ciagu;
        }
        return rezultat;
    }
    }
 }