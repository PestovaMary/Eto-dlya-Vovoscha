using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mafia
{
    class Program
    {
        static void Main(string[] args)
        {
            int MafCount, CivCount, CopCount, PlayersCount=0, i=0;
            List<Player> players = new List<Player>();

            Console.Write("Введите количество игроков: ");
            PlayersCount = int.Parse(Console.ReadLine());

            CopCount = 1;
            MafCount = PlayersCount / 3;
            CivCount = PlayersCount - MafCount - CopCount;

            while(i < MafCount)
            {
                Mafia mafia = new Mafia();
                players.Add(mafia);
                i++;
            }

            i = 0;
            while (i < CopCount)
            {
                Cop cop = new Cop();
                players.Add(cop);
                i++;
            }

            i = 0;
            while (i < CivCount)
            {
                Civil civil = new Civil();
                players.Add(civil);
                i++;
            }

            
            Console.ReadKey();
        }
    }
}
