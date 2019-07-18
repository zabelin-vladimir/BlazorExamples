using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDataGrids.Data
{
    public class WeatherForecastService
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<List<WeatherForecast>> GetForecastAsync(string region)
        {
            var rng = new Random();
            string[] regions = new[] { "North", "West", "East", "South" };
            List<WeatherForecast> forecasts = Enumerable.Range(1, 20).Select(index => new WeatherForecast
            {
                Date = DateTime.Today.AddDays(index),
                TemperatureC = rng.Next(-20, 30),
                Summary = Summaries[rng.Next(Summaries.Length)],
                Region = regions[index % 4]
            }).ToList();

            return Task.FromResult(forecasts.Where(m => m.Region == region).ToList());
        }
        public Task<List<Region>> GetRegions()
        {
            List<Region> regions = new List<Region>();
            regions.Add(new Region() { RegionName = "North" });
            regions.Add(new Region() { RegionName = "West" });
            regions.Add(new Region() { RegionName = "East" });
            regions.Add(new Region() { RegionName = "South" });
            return Task.FromResult(regions);
        }
    }
}
