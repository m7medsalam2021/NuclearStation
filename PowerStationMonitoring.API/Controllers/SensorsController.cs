using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerStationMonitoring.Core.Services;
using PowerStationMonitoring.Infrasturcture.IRepository;

namespace PowerStationMonitoring.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorsController : ControllerBase
    {
        private readonly SensorService _sensorService;
        public SensorsController(SensorService sensorService)
        {
            
            _sensorService = sensorService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSensorById(int id)
        {
            var sensor = await _sensorService.GetSensorByIdAsync(id);
            if (sensor == null)
            {
                return NotFound($"Sensor with ID {id} not found.");
            }
            return Ok(sensor);
        }
        [HttpGet("stream/{id}")]
        public async Task StreamSensorData(int id)
        {
            Response.ContentType = "text/event-stream";

            while (true)
            {
                var sensor = await _sensorService.GetSensorByIdAsync(id);
                if (sensor != null)
                {
                    await Response.WriteAsync($"data: {JsonSerializer.Serialize(sensor)}\n\n");
                    await Response.Body.FlushAsync();
                }

                await Task.Delay(TimeSpan.FromMinutes(0.5));
            }
        }
    }
}
