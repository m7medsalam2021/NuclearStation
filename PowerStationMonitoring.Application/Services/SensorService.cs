using PowerStationMonitoring.Domain.Model;
using PowerStationMonitoring.Infrasturcture.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerStationMonitoring.Core.Services
{
    public class SensorService
    {
        private readonly ISensorRepo _sensorRepo;
        public SensorService(ISensorRepo sensorRepo)
        {
            _sensorRepo = sensorRepo;
        }
        public async Task<Sensor> GetSensorByIdAsync(int id)
        {
            return await _sensorRepo.GetSensorByIdAsync(id);
        }
    }
}
