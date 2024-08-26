using CarVariantMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarVariantMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly CarVariantTestContext _context;

        public AdminController(CarVariantTestContext context)
        {
            _context = context;
        }

        public IActionResult AdminDashboard()
        {
          
          
                // Fetch the counts for the dashboard boxes
                var model = new AdminDashboardViewModel
                {
                    CompanyCount = _context.Companies.Count(),
                    VariantCount = _context.Variants.Count(),
                    CustomerCount = _context.Users.Count(),
                    BookingCount = _context.Bookings.Count()
                };

                return View(model); // 
            
            
        }
    }
}
