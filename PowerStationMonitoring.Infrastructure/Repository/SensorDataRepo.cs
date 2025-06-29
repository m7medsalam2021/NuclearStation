using Microsoft.EntityFrameworkCore;
using PowerStationMonitoring.Core.Model;
using PowerStationMonitoring.Infrastructure.Data;
using PowerStationMonitoring.Infrasturcture.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerStationMonitoring.Infrasturcture.Repository
{
    public class SensorDataRepo : ISensorDataRepo
    {
        private readonly AppDbContext _context;

        public SensorDataRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SensorData>> GetAllSensorData()
        {
            return await _context.SensorData.Include(S => S.Sensor).ToListAsync();
        }

        public async Task<IEnumerable<SensorData>> GetSensorDataBySensorId(int sensorId)
        {
            return await _context.SensorData.Include(s => s.Sensor)
                .Where(s => s.SensorId == sensorId)
                .ToListAsync();
        }
    }
}
