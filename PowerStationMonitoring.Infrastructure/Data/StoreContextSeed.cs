//using PowerStationMonitoring.Core.Model;
//using PowerStationMonitoring.Infrastructure.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;

//namespace PowerStationMonitoring.Infrasturcture.Data
//{
//    public static class StoreContextSeed
//    {
//        public static async Task SeedAsync(AppDbContext context)
//        {
//            if (!context.Masters.Any())
//            {
//                var path = Path.Combine(Directory.GetCurrentDirectory(), "Data/DataSeeding/Master.json");

//                var masterOfController = File.ReadAllText(path);
//                var masters = JsonSerializer.Deserialize<List<Master>>(masterOfController);

//                if (masters != null && masters.Count > 0)
//                {
//                    foreach (var master in masters)
//                    {
//                        await context.Set<Master>().AddAsync(master);
//                    }
//                    await context.SaveChangesAsync();
//                }
//            }

//        }
//    }
//}
