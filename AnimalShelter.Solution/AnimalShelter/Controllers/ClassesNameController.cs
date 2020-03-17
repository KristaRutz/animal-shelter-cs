using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class ClassesNameController : Controller
  {

    private readonly ProjectNameContext _db;

    public ItemsController(ProjectNameContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Item> model = _db.Items.ToList();
      return View(model);
    }

    // [HttpPost]
    // public ActionResult Create(Item item)
    // {
    //   _db.Items.Add(item);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

  }
}