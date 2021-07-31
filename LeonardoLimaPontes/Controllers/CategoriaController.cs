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
            return View();
        }
    }
}
