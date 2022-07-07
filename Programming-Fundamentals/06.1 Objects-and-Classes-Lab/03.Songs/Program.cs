using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());


            List<Song> listOfSongs = new List<Song>();


            for (int i = 1; i <= numberOfSongs; i++)
            {
                string[] songProperties = Console.ReadLine().Split('_').ToArray();

                Song song = new Song
                {
                    TypeList = songProperties[0],
                    Name = songProperties[1],
                    Time = songProperties[2]
                };

                listOfSongs.Add(song);
            }

            string typeList = Console.ReadLine();

            switch (typeList)
            {
                case "all":
                    foreach (var song in listOfSongs)
                    {
                        Console.WriteLine(song.Name);
                    }
                    break;
                default:
                    foreach (var song in listOfSongs)
                    {
                        if (song.TypeList == typeList)
                        {
                            Console.WriteLine(song.Name);
                        }
                    }
                    break;
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
