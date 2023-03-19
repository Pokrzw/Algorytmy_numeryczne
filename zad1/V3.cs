using System;
using System.Numerics;

 namespace Zad1{
    class V3{
    static public List<decimal> ciag(BigInteger ilosc_wyrazow, double wartosc_do_obliczenia, int[] wartosci_pochodnych){       
        var rezultat = new List<decimal>();
        decimal niezerowy_wyraz = 0;
        decimal wyraz_ciagu = 0;
        double radiany = (wartosc_do_obliczenia) * Program.pi/(double)180.0;
        int index = 0;

        if(wartosc_do_obliczenia == 0){
            rezultat.Add(0);
            return rezultat;
        }
        while(niezerowy_wyraz == 0){
            int wartosc_pochodnej = wartosci_pochodnych[ index % wartosci_pochodnych.Length ];
            niezerowy_wyraz = (decimal)(wartosc_pochodnej / Program.silnia(index) * (Program.potegi((radiany), index)));
            index ++;            
        }
        index = index - 1;

        if(index >= ilosc_wyrazow){
            return rezultat;
        }
        int wartosc_niezerowej_pochodnej;
        for(int i = index ; i < ilosc_wyrazow; i++){
            int wartosc_pochodnej = wartosci_pochodnych[ i % wartosci_pochodnych.Length ];
            wartosc_niezerowej_pochodnej = wartosci_pochodnych[ index % wartosci_pochodnych.Length ];
            wyraz_ciagu = niezerowy_wyraz;
            wyraz_ciagu = wyraz_ciagu /  wartosc_niezerowej_pochodnej * wartosc_pochodnej;

            for(int j = index + 1; j<= i; j++){
                wyraz_ciagu /= j;
                wyraz_ciagu *= (decimal)radiany;
            }

                if(wyraz_ciagu !=0){
                    niezerowy_wyraz = wyraz_ciagu;
                    index = i;
                    rezultat.Add(niezerowy_wyraz);                                     
            }
            
        }
        return rezultat;
    }

    public decimal suma_wyrazow(List<decimal> wyrazy){
        decimal wynik = 0;
        foreach(decimal wyraz in wyrazy){
            wynik += wyraz;
        }

        return wynik;
    }

    public decimal suma_od_przodu(BigInteger ilosc_wyrazow, double wartosc_do_obliczenia, int[] wartosci_pochodnych){
        List<decimal> rezultat = V3.ciag(ilosc_wyrazow, wartosc_do_obliczenia, wartosci_pochodnych);
        decimal wynik = suma_wyrazow(rezultat);
        return wynik;
    }

    }
 }

