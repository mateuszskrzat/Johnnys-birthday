using System;

namespace UrodzinyJasia
{
    class OstatniaSwieczka
    {
        long l, z, z1; //l = ilosc świeczek, z = cyfra 2^n, z1 = zmienna pomocnicza, zapisująca 2^n-1
        int n; // potęgi liczby 2
        public OstatniaSwieczka() {
            Console.WriteLine("Podaj ile świeczek ma zdmuchnąć Jaś");
            l = int.Parse(Console.ReadLine()); //wczytanie ilosci świeczek
            z = 2;//z = 2^1
            n = 2;
            WypiszOstatniaSwieczke();
        }
        void WypiszOstatniaSwieczke() {
            while (true)
            {
                if (l > z + 1)//if ilość świeczek > (2^n) + 1 => z = z + 2^(n)
                {
                    z1 = z; //zapis z do zmiennej z1
                    z = z + (long)Math.Pow(2, n); //dodawanie kolejnej potegi
                    n++; //zwiekszanie potegi o 1
                }
                else if (l == z + 1)//jesli zmienna l jest rowna spotegowanemu (2^n) + 1, ostatnia zapalona świeczka to (2^n) + 1
                { 
                    Console.WriteLine("Ostatnia zapalona świeczka to " + (z + 1));
                    break;
                }
                else //jesli liczba świeczek jest mniejsza od z+1
                { 
                    Console.WriteLine("Ostatnia zapalona świeczka to " + ((((z1 + l + 1) % (z + 1)) * 2) + 1));//((((2^(n-1) + ilość świeczek + 1) mod ((2^n) + 1)) * 2) + 1)
                    //pobieramy z1 jako poprzednio spotegowana z, dodajemy liczbe osob i cyfre 1, obliczamy reszte z dzielenia sumy przez z + 1
                    //wynik ten mnozymy razy 2, i na koniec dodajemy 1, wynikiem jest ostatnia zapalona świeczka
                    break;
                }
            }
        }
    }
}
