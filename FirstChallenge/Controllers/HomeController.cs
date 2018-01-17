using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstChallenge.Models;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var ComicBooks = ComicBookManager.GetComicBooks();
            return View(ComicBooks);
        }

        public ActionResult Detail(int id)
        {
            var ComicBooks = ComicBookManager.GetComicBooks();
            var comicBook = ComicBooks.FirstOrDefault(p=> p.ComicBookId == id);

            return View(comicBook);
        }
    }
}