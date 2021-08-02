using LeonardoLimaPontes.Data;
using LeonardoLimaPontes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeonardoLimaPontes.Controllers
{
    public class TipoAplicacaoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TipoAplicacaoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<TipoAplicacao> objList = _db.TipoAplicacao;
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
        public IActionResult Create(TipoAplicacao obj)
        {
            _db.TipoAplicacao.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
