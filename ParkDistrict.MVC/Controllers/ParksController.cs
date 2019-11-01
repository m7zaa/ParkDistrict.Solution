using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkDistrict.Models;

namespace ParkDistrict.Controllers
{
    public class ParksController : Controller
    {

        //   public IActionResult Index () {
        //       var parkList = Park.ParkList ();
        //       return View (parkList);
        //   }

        public IActionResult Index(string search)
        {
            var parkList = Park.ParkListSearch(search);
            return View(parkList);
        }

        [HttpGet("Parks/{id}")]
        public ActionResult Details(int id)
        {
            Park thisPark = Park.ParkDetails(id);
            return View(thisPark);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Park park)
        {
            await park.ParkCreate();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id, string name)
        {
            var park = Park.ParkDetails(id);
            return View(park);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await Park.ParkDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var park = Park.ParkDetails(id);
            return View(park);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Park park)
        {
            await Park.ParkEdit(park);
            return RedirectToAction("Index");
        }
    }
}