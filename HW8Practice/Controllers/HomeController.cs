using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW8Practice.Models;

namespace HW8Practice.Controllers
{
    public class HomeController : Controller
    {

        private dbContext db = new dbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Artworks
        public ActionResult Artworks()
        {
            var tmp = db.Artworks;
            List<ArtistArtworkVM> arts = new List<ArtistArtworkVM>();

            foreach (var i in tmp)
            {
                arts.Add(new ArtistArtworkVM(db.Artists.Where(s => s.id == (i.idA)).FirstOrDefault(), i));
            }

            return View(arts);
        }

        // GET: Classifications
        public ActionResult Classifications()
        {
            var tmp = db.Artworks;
            List<GenreArtworkVM> classies = new List<GenreArtworkVM>();

            foreach (var i in tmp)
            {
                classies.Add(new GenreArtworkVM(db.Genres.Where(s => s.id == (db.Classifications.Where(d => d.idA == i.id)).Select(f => f.idG).FirstOrDefault()).FirstOrDefault(), i));
            }

            return View(classies);
        }
    }
}