using PowerStationMonitoring.Core.Model;
using PowerStationMonitoring.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PowerStationMonitoring.Domain.ViewModels
{
    public class SensorDataDto
    {
        public int SensorDataId { get; set; }
        public DateTime Timestamp { get; set; }
        public string MeasurementType { get; set; }
        public string Unit { get; set; }
        public decimal MeasuredValue { get; set; }
        public string Notes { get; set; }
        public int SensorId { get; set; }
        public SensorDto Sensor { get; set; }
    }
}
