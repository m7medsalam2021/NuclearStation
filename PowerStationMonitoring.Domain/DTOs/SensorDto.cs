using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerStationMonitoring.Domain.DTOs
{
    public class SensorDto
    {
        public int SensorId { get; set; }
        public string SensorName { get; set; }
        public string SensorType { get; set; }
        public double Value { get; set; }             
        public DateTime Timestamp { get; set; }
    }
}
