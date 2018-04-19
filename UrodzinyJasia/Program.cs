using System;

namespace UrodzinyJasia
{
    //TREŚĆ ZADANIA
    //Kiedy Jaś obchodzi swoje urodziny, dostaje zawsze tort ze świeczkami, które są ponumerowane i uporządkowane rosnąco po okręgu.
    //Jaś zaczynając od pierwszej świeczki, zdmuchuje co drugą niezgaszoną świeczkę (pierwsza zdmuchnięta świeczka to nr 2) tak długo,
    //aż pozostanie tylko jedna. Jasia przed rytuałem zdmuchiwania zawsze zastanawia, która świeczka pozostanie niezgaszona.
    //Pomóż Jasiowi odpowiedzieć na to pytanie, wiedząc, które urodziny obchodzi
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                OstatniaSwieczka ostatnia = new OstatniaSwieczka();
                Console.ReadKey();
            }
        }
    }
}
