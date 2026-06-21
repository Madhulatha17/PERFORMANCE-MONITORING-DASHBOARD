namespace PerformanceMonitoringDashboard.Models
{
    public class MetricViewModel
    {
        public double AverageResponseTime { get; set; }

        public int TotalRequests { get; set; }

        public int FailedRequests { get; set; }

        public int Exceptions { get; set; }

        public int Dependencies { get; set; }
    }
}
