using Microsoft.EntityFrameworkCore;
using PowerStationMonitoring.Core.Model;
using PowerStationMonitoring.Domain.Model;

namespace PowerStationMonitoring.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
           // modelBuilder.Entity<Slave>()
           //.HasOne(s => s.Master)
           //.WithMany(m => m.Slaves)
           //.HasForeignKey(s => s.MasterId);
            
            //modelBuilder.Entity<Sensor>()
            //    .HasOne(s => s.Slave)
            //    .WithMany(sl => sl.Sensors)
            //    .HasForeignKey(s => s.SlaveId);

            modelBuilder.Entity<SensorData>()
                .HasOne(sd => sd.Sensor)
                .WithMany(s => s.SensorData)
                .HasForeignKey(sd => sd.SensorId);

            //modelBuilder.Entity<Master>()
            //    .Property(m => m.MasterName)
            //    .IsRequired()
            //    .HasMaxLength(100);

            //modelBuilder.Entity<Slave>()
            //    .Property(s => s.SlaveName)
            //    .IsRequired()
            //    .HasMaxLength(100);

            modelBuilder.Entity<Sensor>()
                .Property(s => s.SensorName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Sensor>()
                .Property(s => s.SensorType)
                .IsRequired()
                .HasMaxLength(50);

            //modelBuilder.Entity<Master>().HasData(
            //    new Master { MasterId = 1, MasterName = "MasterController1" },
            //    new Master { MasterId = 2, MasterName = "MasterController2" }
            //);

            //modelBuilder.Entity<Slave>().HasData(
            //    new Slave { SlaveId = 1, SlaveName = "Slave_Controller_1", MasterId = 1 },
            //    new Slave { SlaveId = 2, SlaveName = "Slave_Controller_2", MasterId = 1 },
            //    new Slave { SlaveId = 3, SlaveName = "Slave_Controller_3", MasterId = 2 },
            //    new Slave { SlaveId = 4, SlaveName = "Slave_Controller_4", MasterId = 2 },
            //    new Slave { SlaveId = 5, SlaveName = "Slave_Controller_5", MasterId = 1 },
            //    new Slave { SlaveId = 6, SlaveName = "Slave_Controller_6", MasterId = 2 }
            //);
            
            modelBuilder.Entity<Sensor>().HasData(
                new Sensor { SensorId = 1, SensorName = "Temperature", SensorType = "Temperature", SlaveId = 1 },
                new Sensor { SensorId = 2, SensorName = "Pressure", SensorType = "Pressure", SlaveId = 2 },
                new Sensor { SensorId = 3, SensorName = "Radiation", SensorType = "Radiation", SlaveId = 3 },
                new Sensor { SensorId = 4, SensorName = "Humidity", SensorType = "Humitdity", SlaveId = 4 },
                new Sensor { SensorId = 5, SensorName = "Flow", SensorType = "Flow", SlaveId = 5 }
                
            );
            
            modelBuilder.Entity<SensorData>().HasData(
                new SensorData { SensorDataId = 1, SensorId = 1, MeasurementType = "Temperature", Unit = "Celsius", MeasuredValue = 25.5m, Notes = "Normal" },
                new SensorData { SensorDataId = 2, SensorId = 2, MeasurementType = "Pressure", Unit = "Pascal", MeasuredValue = 101325m, Notes = "Normal" },
                new SensorData { SensorDataId = 3, SensorId = 3, MeasurementType = "Radiation", Unit = "mSv/h", MeasuredValue = 0.1m, Notes = "Normal" },
                new SensorData { SensorDataId = 4, SensorId = 4, MeasurementType = "Humidity", Unit = "%", MeasuredValue = 45.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 5, SensorId = 5, MeasurementType = "Flow", Unit = "L/min", MeasuredValue = 10.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 6, SensorId = 1, MeasurementType = "Temperature", Unit = "Celsius", MeasuredValue = 26.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 7, SensorId = 5, MeasurementType = "Flow", Unit = "L/min", MeasuredValue = 12.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 8, SensorId = 2, MeasurementType = "Pressure", Unit = "Pascal", MeasuredValue = 102000m, Notes = "Normal" },
                new SensorData { SensorDataId = 9, SensorId = 4, MeasurementType = "Humidity", Unit = "%", MeasuredValue = 50.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 10, SensorId = 3, MeasurementType = "Radiation", Unit = "mSv/h", MeasuredValue = 0.2m, Notes = "Normal" },
                new SensorData { SensorDataId = 11, SensorId = 2, MeasurementType = "Pressure", Unit = "Pascal", MeasuredValue = 101500m, Notes = "Normal" },
                new SensorData { SensorDataId = 12, SensorId = 2, MeasurementType = "Pressure", Unit = "Pascal", MeasuredValue = 101800m, Notes = "Normal" },
                new SensorData { SensorDataId = 13, SensorId = 1, MeasurementType = "Temperature", Unit = "Celsius", MeasuredValue = 27.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 14, SensorId = 5, MeasurementType = "Flow", Unit = "L/min", MeasuredValue = 15.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 15, SensorId = 1, MeasurementType = "Temperature", Unit = "Celsius", MeasuredValue = 28.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 16, SensorId = 5, MeasurementType = "Flow", Unit = "L/min", MeasuredValue = 18.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 17, SensorId = 1, MeasurementType = "Temperature", Unit = "Celsius", MeasuredValue = 29.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 18, SensorId = 2, MeasurementType = "Pressure", Unit = "Pascal", MeasuredValue = 102500m, Notes = "Normal" },
                new SensorData { SensorDataId = 19, SensorId = 3, MeasurementType = "Radiation", Unit = "mSv/h", MeasuredValue = 0.3m, Notes = "Normal" },
                new SensorData { SensorDataId = 20, SensorId = 4, MeasurementType = "Humidity", Unit = "%", MeasuredValue = 55.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 21, SensorId = 5, MeasurementType = "Flow", Unit = "L/min", MeasuredValue = 20.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 22, SensorId = 1, MeasurementType = "Temperature", Unit = "Celsius", MeasuredValue = 30.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 23, SensorId = 5, MeasurementType = "Flow", Unit = "L/min", MeasuredValue = 22.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 24, SensorId = 2, MeasurementType = "Pressure", Unit = "Pascal", MeasuredValue = 103000m, Notes = "Normal" },
                new SensorData { SensorDataId = 25, SensorId = 4, MeasurementType = "Humidity", Unit = "%", MeasuredValue = 60.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 26, SensorId = 3, MeasurementType = "Radiation", Unit = "mSv/h", MeasuredValue = 0.4m, Notes = "Normal" },
                new SensorData { SensorDataId = 27, SensorId = 2, MeasurementType = "Pressure", Unit = "Pascal", MeasuredValue = 103500m, Notes = "Normal" },
                new SensorData { SensorDataId = 28, SensorId = 2, MeasurementType = "Pressure", Unit = "Pascal", MeasuredValue = 104000m, Notes = "Normal" },
                new SensorData { SensorDataId = 29, SensorId = 1, MeasurementType = "Temperature", Unit = "Celsius", MeasuredValue = 31.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 30, SensorId = 5, MeasurementType = "Flow", Unit = "L/min", MeasuredValue = 25.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 31, SensorId = 1, MeasurementType = "Temperature", Unit = "Celsius", MeasuredValue = 25.5m, Notes = "Normal" },
                new SensorData { SensorDataId = 32, SensorId = 2, MeasurementType = "Pressure", Unit = "Pascal", MeasuredValue = 101325m, Notes = "Normal" },
                new SensorData { SensorDataId = 33, SensorId = 3, MeasurementType = "Radiation", Unit = "mSv/h", MeasuredValue = 0.1m, Notes = "Normal" },
                new SensorData { SensorDataId = 34, SensorId = 4, MeasurementType = "Humidity", Unit = "%", MeasuredValue = 45.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 35, SensorId = 5, MeasurementType = "Flow", Unit = "L/min", MeasuredValue = 10.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 36, SensorId = 1, MeasurementType = "Temperature", Unit = "Celsius", MeasuredValue = 26.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 37, SensorId = 5, MeasurementType = "Flow", Unit = "L/min", MeasuredValue = 12.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 38, SensorId = 2, MeasurementType = "Pressure", Unit = "Pascal", MeasuredValue = 102000m, Notes = "Normal" },
                new SensorData { SensorDataId = 39, SensorId = 4, MeasurementType = "Humidity", Unit = "%", MeasuredValue = 50.0m, Notes = "Normal" },
                new SensorData { SensorDataId = 40, SensorId = 3, MeasurementType = "Radiation", Unit = "mSv/h", MeasuredValue = 0.2m, Notes = "Normal" }
            );
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<SensorData> SensorData { get; set; }
        //public DbSet<Slave> Slaves { get; set; }
        //public DbSet<Master> Masters { get; set; }
    }
}
