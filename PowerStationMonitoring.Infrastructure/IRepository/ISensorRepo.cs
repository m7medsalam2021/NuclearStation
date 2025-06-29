using PowerStationMonitoring.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerStationMonitoring.Infrasturcture.IRepository
{
    public interface ISensorRepo
    {
        Task<Sensor> GetSensorByIdAsync(int id);
    }
    
}
