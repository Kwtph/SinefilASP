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
                new Movie(){ Id=1, Name="Vol-İ (Wall-e)", Description="Vol.i, günümüzden çok uzak bir gelecekte geçmektedir. Filmde, insanoğlu aşırı kirlenme sebebiyle Dünya’yı terk edip başka bir gezegende yaşamaya başlamıştır. Çöplerle çevrili dünyayı temizleme görevi sevimli bir robota, Vol.i’ye verilir. İnsanoğlunun bıraktığı çöplerden kendine yeni bir dünya yaratan yalnız Vol.i’nin yalnızlığı, başka bir robot olan Eve’nın gelmesiyle son bulur. İki sevimli robotun arasında filizlenen dokunaklı ilişki türlü zorluklara rağmen direnmeye ve ayakta kalmaya çalışır.", Yonetmen= "Andrew Stanton", Oyuncular="Ben Burtt, Elissa Knight, Jeff Garlin, Fred Willard, John Ratzenberger", ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/jzCpGwWHUwby14KPJJWla9ybY81.jpg", TrailerUrl="https://www.youtube.com/embed/jpzeyPfMxwA", CategoryId=1,IMDbStar="tt0910970"},
                new Movie(){ Id=2, Name="Yukarı Bak (Up)", Description="Hayatı boyunca yaşamak istediği macera hayalini gerçekleştirmek için evine binlerce balon bağlayıp Güney Amerika'nın vahşi doğasına doğru yolculuğa çıkan 78 yaşındaki baloncu Carl Fredricksen'ın hikayesinin anlatıldığı yeni bir komedi. Ancak Carl, yolculuğa başladıktan sonra en büyük kabusunu da yanında götürmekte olduğunu fark eder: fazlasıyla iyimser, doğa kaşifi 8 yaşındaki Russel'ı...", Yonetmen= "Pete Docter", Oyuncular="Ed Asner, Christopher Plummer, Jordan Nagai, Bob Peterson, Delroy Lindo", ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/c9QLSX3qEW8FO7UgT2pyfC1LDzb.jpg", TrailerUrl="https://www.youtube.com/embed/n0ODbDufkXM", IMDbStar="tt1049413", CategoryId=1},
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
