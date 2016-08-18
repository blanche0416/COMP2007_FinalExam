﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_FinalExam.Models;

namespace COMP2007_FinalExam.Controllers
{
    public class StoreController : Controller
    {
        MVCMusicStoreContext StoreDB = new MVCMusicStoreContext();
        // GET: Store
        public ActionResult Index()
        {
            List<Genres> genres = StoreDB.Genres.ToList();
            return View(genres);
        }
        public ActionResult Browse(string geners = "Rock")
        {
            Genres genreModel = StoreDB.Genres.Include("Albums").Single(g => g.Name == geners);
            return View(genreModel);
        }

        public ActionResult Details(int id = 1)
        {
            Albums album = StoreDB.Albums.Find(id);
            return View(album);
        }

    }
}