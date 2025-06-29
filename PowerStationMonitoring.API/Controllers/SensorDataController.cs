using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PowerStationMonitoring.Core.Services;

namespace PowerStationMonitoring.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorDataController : ControllerBase
    {
        private readonly SensorDataService _sensorDataService;
        public SensorDataController(SensorDataService sensorDataService)
        {
            _sensorDataService = sensorDataService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSensorData()
        {
            var sensorData = await _sensorDataService.GetAllSensorDataWithSensorAsync();
            if(sensorData is null)
            {
                return NotFound("Not Found Data");
            }
            return Ok(sensorData);
        }
        [HttpGet("{sensorId}")]
        public async Task<IActionResult> GetSensorDataById(int sensorId)
        {
            var sensorData = await _sensorDataService.GetSensorDataByIdAsync(sensorId);
            if (sensorData == null)
            {
                return NotFound($"SensorData with ID {sensorId} not found.");
            }

            return Ok(new
            {
                id = sensorData.SensorDataId,
                value = sensorData.MeasuredValue,
                timestamp = sensorData.Timestamp,
                measurementType = sensorData.MeasurementType,
                unit = sensorData.Unit,
                notes = sensorData.Notes,
                sensorId = sensorData.SensorId,
            });
        }

    }
}
