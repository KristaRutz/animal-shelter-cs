using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {

    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index(string sortBy)
    {
      List<Animal> sortedBy = _db.Animals.ToList();

      if (sortBy == "byName")
      {
        sortedBy = _db.Animals.OrderBy(animals => animals.Name).ToList();
      }
      else if (sortBy == "byBreed")
      {
        sortedBy = _db.Animals.OrderBy(animals => animals.Breed).ToList();
      }
      else if (sortBy == "byType")
      {
        sortedBy = _db.Animals.OrderBy(animals => animals.AnimalType).ToList();
      }
      else if (sortBy == "byDateAdmitted")
      {
        sortedBy = _db.Animals.OrderBy(animals => animals.DateAdmitted).ToList();
      }

      Dictionary<string, List<Animal>> model = new Dictionary<string, List<Animal>> {};
      model.Add("sortBy", sortedBy);
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Animal model = _db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
      return View(model);
    }

  }
}