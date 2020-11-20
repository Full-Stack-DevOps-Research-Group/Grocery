using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GroceryStore.Models;

namespace GroceryStore.Controllers
{
    public class GroceryController : Controller
    {
        private IGroceryRepository _repository;

        public GroceryController(IGroceryRepository repository)
        {
            _repository = repository;
        }

        // GET: Grocery
        public ActionResult Index()
        {
            return View(_repository.GetItems());
        }

        // GET: Grocery/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grocery/Create
        [HttpPost]
        public ActionResult Create(GroceryItem item)
        {
            _repository.AddItem(item);
            _repository.SaveChanges();

            return RedirectToAction("Index");
        }

        //// GET: Grocery/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Grocery/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Grocery/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Grocery/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}