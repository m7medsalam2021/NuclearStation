using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using PowerStationMonitoring.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerStationMonitoring.Core.Model
{
    public class SensorData
    {
        public int SensorDataId { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string MeasurementType { get; set; }
        public string Unit { get; set; }
        public decimal MeasuredValue { get; set; }
        public string Notes { get; set; }

        // Foreign key
        public int SensorId { get; set; }

        // Navigation property
        [ValidateNever]
        public virtual Sensor Sensor { get; set; }
    }
}
