using PerformanceMonitoringDashboard.Models;

namespace PerformanceMonitoringDashboard.Services
{
    public class ApplicationInsightsService
    {
        public MetricViewModel GetMetrics()
        {
            return new MetricViewModel
            {
                AverageResponseTime = 145.8,
                TotalRequests = 2500,
                FailedRequests = 12,
                Exceptions = 5,
                Dependencies = 420
            };
        }
    }
}
