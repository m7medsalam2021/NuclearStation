using PowerStationMonitoring.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerStationMonitoring.Infrasturcture.IRepository
{
    public interface ISensorDataRepo
    {
        public Task<IEnumerable<SensorData>> GetAllSensorData();
        public Task<IEnumerable<SensorData>> GetSensorDataBySensorId(int sensorId);
    }
}
