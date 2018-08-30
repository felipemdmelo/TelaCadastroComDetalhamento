using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelaCadastroComDetalhamento.Models;

namespace TelaCadastroComDetalhamento.Controllers
{
    public class FamiliaController : Controller
    {
        // GET: Familia
        public ActionResult Index()
        {
            var result = new List<Pai>();

            result.Add(new Pai()
            {
                Nome = "Felipe",
                Filhos = new List<Filho>() { new Filho() { Nome = "Luma" }, new Filho() { Nome = "Isac" } }
            });

            return View(result);
        }

        // GET: Familia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Familia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Familia/Create
        [HttpPost]
        public JsonResult _Create(List<PaiFilhoCreate> model)
        {
            try
            {
                // TODO: Add insert logic here

                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        // GET: Familia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Familia/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Familia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Familia/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}