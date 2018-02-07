using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agua.Models;

namespace Agua.Controllers
{
    public class HomeController : Controller
    {
        public DateTime TimeSpan { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
            int noches;
            int Botella = 12;
            int botellaxdia;
            
            DateTime Hoy =DateTime.Today;
            TimeSpan resta = ProximoCumple - Hoy;
            noches=resta.Days;
            botellaxdia = minutos * resta.Days * Botella;

            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding 


            ViewBag.Dias = noches;
            ViewBag.Botellas = botellaxdia;
            return View();
        }

    }
}
