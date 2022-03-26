using System;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song()
            {
                Title = "Nothing else matters",
                Length = 3.5,
                Genre = Enums.Genres.Rock
            };
            List<Song> songs = new List<Song>();
            songs.Add(song);

            List<Song> songs2 = new List<Song>();

            Person igor = new Person()
            {
                FirstName = "Igor",
                LastName = "Nikoloski",
                Age = 25,
                FavoriteMusicType = Enums.Genres.Techno,
                Songs = songs2,
            };

            igor.GetFavSongs();




            Console.ReadLine();
        }
    }
}
