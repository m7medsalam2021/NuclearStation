//using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
//using PowerStationMonitoring.Domain.Model;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PowerStationMonitoring.Core.Model
//{
//    public class Slave
//    {
//        public int SlaveId { get; set; }
//        public string SlaveName { get; set; }

//        // Foreign key
//        public int MasterId { get; set; }

//        // Navigation properties
//        public Master Master { get; set; }
//        [ValidateNever]
//        public ICollection<Sensor> Sensors { get; set; } = new List<Sensor>();
//    }
//}
