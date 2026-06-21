using Microsoft.AspNetCore.Mvc;
using PerformanceMonitoringDashboard.Services;

namespace PerformanceMonitoringDashboard.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationInsightsService _service;

        public DashboardController(
            ApplicationInsightsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var metrics = _service.GetMetrics();
            return View(metrics);
        }
    }
}
