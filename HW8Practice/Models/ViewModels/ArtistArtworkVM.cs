using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW8Practice.Models
{
    public class ArtistArtworkVM
    {
        public Artist artist = new Artist();
        public Artwork artwork = new Artwork();

        public ArtistArtworkVM(Artist artistP, Artwork artworkP)
        {
            artist = artistP;
            artwork = artworkP;
        }
    }
}