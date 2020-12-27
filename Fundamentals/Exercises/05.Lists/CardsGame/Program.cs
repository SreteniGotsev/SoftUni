using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> handOne = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList();

            List<int> handTwo = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList();

            int currentCardPlayerOne = 0;
            int currentCardPlayerTwo = 0;

            string winner = string.Empty;
            while (handOne.Count != 0 && handTwo.Count != 0)
            {
                currentCardPlayerOne = handOne[0];
                currentCardPlayerTwo = handTwo[0];
                winner = Clash(currentCardPlayerOne, currentCardPlayerTwo);

                if (winner == "playerOne")
                {
                    handOne.Add(currentCardPlayerOne);
                    handOne.Add(currentCardPlayerTwo);
                    handOne.RemoveAt(0);
                    handTwo.RemoveAt(0);

                }
                else if (winner == "playerTwo")
                {
                    handTwo.Add(currentCardPlayerTwo);
                    handTwo.Add(currentCardPlayerOne);
                    handTwo.RemoveAt(0);
                    handOne.RemoveAt(0);
                }
                else if (winner == "noOne")
                {
                    handOne.RemoveAt(0);
                    handTwo.RemoveAt(0);
                }
            }

            string playerWinner = string.Empty;
            int sum = 0;
            List<int> hand = new List<int>();

            if (handTwo.Count == 0)
            {
                playerWinner = "First";
                hand = handOne;
            }
            else if (handOne.Count == 0)
            {
                playerWinner = "Second";
                hand = handTwo;
            }

            for (int i = 0; i < hand.Count; i++)
            {
                sum += hand[i];
            }

            Console.WriteLine($"{playerWinner} player wins! Sum: {sum}");
        }

        private static string Clash(int cardP1, int cardp2)
        {
            string winner = string.Empty;

            if (cardP1 > cardp2)
            {
                winner = "playerOne";
            }
            else if (cardP1 < cardp2)
            {
                winner = "playerTwo";
            }
            else if (cardP1 == cardp2)
            {
                winner = "noOne";
            }

            return winner;
        }
    }
}
