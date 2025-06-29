using Microsoft.EntityFrameworkCore;
using PowerStationMonitoring.Domain.Model;
using PowerStationMonitoring.Infrastructure.Data;
using PowerStationMonitoring.Infrasturcture.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerStationMonitoring.Infrasturcture.Repository
{
    public class SensorRepo : ISensorRepo
    {
        private readonly AppDbContext _context;

        public SensorRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Sensor> GetSensorByIdAsync(int id)
        {
            return await _context.Sensors.FirstOrDefaultAsync(s => s.SensorId == id);

        }
    }
    
}
