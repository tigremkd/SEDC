using SEDC.Oop.Class08.Exercise2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.Exercise2
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genres FavoriteMusicType { get; set; }

        public List<Song> Songs { get; set; }

        public void GetFavSongs()
        {
            if (Songs == null || Songs.Count == 0)
            {
                Console.WriteLine($"This {FirstName} hates music .");
            }
                foreach (Song song in Songs)
            {
                Console.WriteLine(song.Title);
               
            }
        }
    }
}
