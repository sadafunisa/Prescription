using Microsoft.AspNetCore.Mvc;
using PrescriptionApp.Models;
using System.Linq;

namespace PrescriptionApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly PrescriptionContext _context;

        public HomeController(PrescriptionContext ctx)
        {
            _context = ctx;
        }

        public IActionResult Index()
        {
            var prescriptions = _context.Prescriptions
                .OrderBy(p => p.MedicationName)
                .ToList();

            return View(prescriptions);
        }
    }
}
