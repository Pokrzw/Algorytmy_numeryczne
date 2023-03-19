using System;
using System.Numerics;
 namespace Zad1{
    class V4{
    public decimal suma_wyrazow(List<decimal> wyrazy){
        decimal wynik = 0;
        int length = wyrazy.Count;
        for(int i = length-1; i>=0; i--){;
            wynik += wyrazy[i];
        }

        return wynik;
    }

    public decimal suma_od_tylu(BigInteger ilosc_wyrazow, double wartosc_do_obliczenia, int[] wartosci_pochodnych){
        List<decimal> rezultat = V3.ciag(ilosc_wyrazow, wartosc_do_obliczenia, wartosci_pochodnych);
        decimal wynik = suma_wyrazow(rezultat);
        return wynik;
    }
    }
 }

