using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using PowerStationMonitoring.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PowerStationMonitoring.Domain.Model
{
    public class Sensor
    {
        public int SensorId { get; set; }
        public string SensorName { get; set; }
        public string SensorType { get; set; }

        // Foreign key
        public int SlaveId { get; set; }

        // Navigation properties
        //public Slave Slave { get; set; }
        [ValidateNever]
        public ICollection<SensorData> SensorData { get; set; } = new List<SensorData>();
    }
}
