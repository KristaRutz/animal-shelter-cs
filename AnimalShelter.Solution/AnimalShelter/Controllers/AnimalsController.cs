using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {

    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animals.ToList();
      return View(model);
    }

    // [HttpPost]
    // public ActionResult Create(Animal animal)
    // {
    //   _db.Animals.Add(animal);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

  }
}