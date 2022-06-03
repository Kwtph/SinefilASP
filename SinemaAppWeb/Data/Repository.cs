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
        public static List<Movie> _movies = null; //_movies isimli boş bir liste oluşturduk.
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){ Id=1, Name="Titanic", Description="A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.", Yonetmen= "James Cameron", Oyuncular="Leonardo DiCaprio, Kate Winslet, Billy Zane", ImageUrl="https://tr.web.img4.acsta.net/r_1280_720/medias/nmedia/18/89/86/41/20070382.jpg", TrailerUrl="https://www.youtube.com/embed/kVrqfYjkTdQ", CategoryId=1,IMDbStar="tt0120338"},
                new Movie(){ Id=2, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=1},
                new Movie(){ Id=3, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=2},
                new Movie(){ Id=4, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=2},
                new Movie(){ Id=5, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=3},
                new Movie(){ Id=6, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=3},
                new Movie(){ Id=7, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=4},
                new Movie(){ Id=8, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=4},
                new Movie(){ Id=9, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=5},
                new Movie(){ Id=10, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=5},
                new Movie(){ Id=11, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=6},
                new Movie(){ Id=12, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=6},
                new Movie(){ Id=13, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=7},
                new Movie(){ Id=14, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=7},
                new Movie(){ Id=15, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=8},
                new Movie(){ Id=16, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=8},
                new Movie(){ Id=17, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=9},
                new Movie(){ Id=18, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=9},
                new Movie(){ Id=19, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=10},
                new Movie(){ Id=20, Name="", Description="", Yonetmen= "", Oyuncular="", ImageUrl="", CategoryId=10},

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
