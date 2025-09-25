using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TF_HospitalDeApoyoDeCoraCora.Models;

namespace TF_HospitalDeApoyoDeCoraCora.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegistrarPaciente()
        {
            return View();
        }
        public IActionResult LoginPaciente()
        {
            return View();
        }

        public IActionResult DetalleDoctor()
        {
            return View();
        }
        public IActionResult DetallePaciente()
        {
            return View();
        }
        public IActionResult ListaCitas()
        {
            return View();
        }
        public IActionResult ListaDoctores()
        {
            return View(); 
        }
        public IActionResult ListaPacientes()
        {
            return View();
        }
        public IActionResult ListaProductos()
        {
            return View();
        }
        public IActionResult RegistrarCita()
        {
            return View();
        }
        public IActionResult RegistrarDoctor()
        {
            return View();
        }
        public IActionResult RegistrarFUA()
        {
            return View();
        }
        public IActionResult RegistrarProducto()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
