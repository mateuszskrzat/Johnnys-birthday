using System;

namespace UrodzinyJasia
{
    //TREŚĆ ZADANIA
    //Kiedy Jaś obchodzi swoje urodziny, dostaje zawsze tort ze świeczkami, które są ponumerowane i uporządkowane rosnąco po okręgu.
    //Jaś zaczynając od pierwszej świeczki, zdmuchuje co drugą niezgaszoną świeczkę (pierwsza zdmuchnięta świeczka to nr 2) tak długo,
    //aż pozostanie tylko jedna. Jasia przed rytuałem zdmuchiwania zawsze zastanawia, która świeczka pozostanie niezgaszona.
    //Pomóż Jasiowi odpowiedzieć na to pytanie, wiedząc, które urodziny obchodzi

    /*
    PROBLEM:
    When it's Johnny's birthday, he always gets a cake with candles which are all numbered and placed in an ascending order around a circle.
    Johnny blows the candles out starting from the first one and blowing out every second candle which is still lit (so that the first blown out candle on the cake is the one with number 2).
    He continues to do so until there is only one lit candle left on the cake. Before this ritual, Johnny always wonders which candle will he blow out as the last.
    Help Johnny determine the answer, knowing which birthday he is celebrating.
    */

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
