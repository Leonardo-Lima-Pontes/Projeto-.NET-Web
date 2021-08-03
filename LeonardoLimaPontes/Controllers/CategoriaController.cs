using LeonardoLimaPontes.Data;
using LeonardoLimaPontes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeonardoLimaPontes.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoriaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Categoria> objList = _db.Categoria;
            return View(objList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categoria obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categoria.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);

        }

        //GET - Editar
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Categoria.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - Atualizar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Atualizar(Categoria obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categoria.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);

        }

        //GET - Editar
        public IActionResult Deletar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Categoria.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - Deletar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletarPost(int? id)
        {
            var obj = _db.Categoria.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Categoria.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
