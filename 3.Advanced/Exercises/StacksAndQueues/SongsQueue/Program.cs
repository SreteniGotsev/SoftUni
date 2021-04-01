using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            string[] commands = Console.ReadLine().Split();

            Queue<string> playlist = new Queue<string>();

            foreach (var item in songs)
            {
                playlist.Enqueue(item);
            }

            while (playlist.Count > 0)
            {
                switch (commands[0])
                {
                    case "Add":

                        string song = string.Join(" ", commands).Substring(4);

                        if (!playlist.Contains(song))
                        {
                            playlist.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} already exist!");
                        }


                        break;

                    case "Play":
                        playlist.Dequeue();
                        break;

                    case "Show":

                        Console.WriteLine(string.Join(", ", playlist));

                        break;

                    default:
                        break;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
