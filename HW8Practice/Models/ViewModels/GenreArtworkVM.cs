using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HW8Practice.Models
{
    public class GenreArtworkVM
    {
        public Genre genre = new Genre();
        public Artwork artwork = new Artwork();

        public GenreArtworkVM(Genre genrep, Artwork artworkP)
        {
            genre = genrep;
            artwork = artworkP;
        }
    }
}