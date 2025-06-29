using PowerStationMonitoring.Core.Model;
using PowerStationMonitoring.Domain.DTOs;
using PowerStationMonitoring.Domain.ViewModels;
using PowerStationMonitoring.Infrasturcture.IRepository;

namespace PowerStationMonitoring.Core.Services
{
    public class SensorDataService
    {
        private readonly IBaseRepository<SensorData> _sensorDataRepository;
        private readonly ISensorDataRepo _sensorDataRepo;
        public SensorDataService(IBaseRepository<SensorData> sensorDataRepository, ISensorDataRepo sensorDataRepo)
        {
            _sensorDataRepository = sensorDataRepository;
            _sensorDataRepo = sensorDataRepo;
        }
        public async Task<IEnumerable<SensorDataDto>> GetAllSensorDataWithSensorAsync()
        {
            var sensorDataList = await _sensorDataRepo.GetAllSensorData();

            // تحويل الكائنات إلى DTOs
            var sensorDataDtos = sensorDataList.Select(sd => new SensorDataDto
            {
                SensorDataId = sd.SensorDataId,
                Timestamp = sd.Timestamp,
                MeasurementType = sd.MeasurementType,
                Unit = sd.Unit,
                MeasuredValue = sd.MeasuredValue,
                Notes = sd.Notes,
                SensorId = sd.SensorId,
                Sensor = new SensorDto
                {
                    SensorId = sd.Sensor.SensorId,
                    SensorName = sd.Sensor.SensorName,
                    SensorType = sd.Sensor.SensorType
                }
            }).ToList();

            return sensorDataDtos;
        }

        public async Task<SensorData> GetSensorDataByIdAsync(int id)
        {
         
            
            return await _sensorDataRepository.GetByIdAsync(id);
        }
    }
}
