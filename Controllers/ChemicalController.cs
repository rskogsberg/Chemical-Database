using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChemicalMVCDatabase.Models;

namespace ChemicalMVCDatabase.Controllers
{
  public class ChemicalController : Controller
  {
    ChemicalDataAcessLayer objchemical = new ChemicalDataAcessLayer();

    public IActionResult Index(string searchString)
    {
      List<Chemical> lstChemical = new List<Chemical>();
      lstChemical = objchemical.ChemicalViewAll().ToList();

    if (!String.IsNullOrEmpty(searchString))
    {
      List<Chemical> filteredChemicals = new List<Chemical>();
      filteredChemicals = objchemical.ChemicalSearchByValue(searchString).ToList();
      return View(filteredChemicals);
    }

      return View(lstChemical);
    }
    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind] Chemical chemical)
    {
      if (ModelState.IsValid)
      {
        objchemical.ChemicalAddOrEdit(chemical);
        return RedirectToAction("Index");
      }
      return View(chemical);
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      Chemical chemical = objchemical.ViewChemicalByID(id);

      if (chemical == null)
      {
        return NotFound();
      }
      return View(chemical);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, [Bind]Chemical chemical)
    {
      if (id != chemical.Chemical_ID)
      {
        return NotFound();
      }
      if (ModelState.IsValid)
      {
        objchemical.ChemicalAddOrEdit(chemical);
        return RedirectToAction("Index");
      }
      return View(chemical);
    }

    [HttpGet]
    public IActionResult Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }
      Chemical chemical = objchemical.ViewChemicalByID(id);

      if (chemical == null)
      {
        return NotFound();
      }
      return View(chemical);
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }
      Chemical chemical = objchemical.ViewChemicalByID(id);

      if (chemical == null)
      {
        return NotFound();
      }
      return View(chemical);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int? id)
    {
      objchemical.DeleteChemicalByID(id);
      return RedirectToAction("Index");
    }
  }
}