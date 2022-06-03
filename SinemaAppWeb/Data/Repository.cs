using Microsoft.AspNetCore.Mvc;
using SinemaAppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinemaAppWeb.Data
{
    public class MovieRepository
    {
        private static List<Movie> _movies = null; //_movies isimli boş bir liste oluşturduk.
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=1},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=1},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=2},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=2},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=3},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=3},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=4},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=4},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=5},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=5},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=6},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=6},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=7},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=7},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=8},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=8},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=9},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=9},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=10},
                new Movie(){ Id=1, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=10},

            };
        }

        public static List<Movie> Movies //Tüm filmleri geriye döndürecek
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie film) //gönderilen filmi repository'e ekleyecek
        {
            _movies.Add(film);
        }


        public static Movie GetById(int id) //gelen id bilgisini karşılaştırıp o id'nin bulunduğu filmi geri gönderecek
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}
