using Microsoft.EntityFrameworkCore;
using SeedingExample.Models;
namespace SeedingExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                using (var context = new EFCoreDbContext())
                {
                    // Retrieve and display Countries
                    context.Database.Migrate();
                    Console.WriteLine("=== Country Master Data ===");
                    var countries = context.Countries.ToList();
                    foreach (var country in countries)
                    {
                        Console.WriteLine($"Country ID: {country.CountryId}, Name: {country.CountryName}, Code: {country.CountryCode}");
                    }

                    // Retrieve and display States
                    Console.WriteLine("\n=== State Master Data ===");
                    var states = context.States
                                        .Include(s => s.Country)
                                        .ToList();
                    foreach (var state in states)
                    {
                        Console.WriteLine($"State ID: {state.StateId}, Name: {state.StateName}, Country: {state.Country.CountryName}");
                    }

                    // Retrieve and display Cities
                    Console.WriteLine("\n=== City Master Data ===");
                    var cities = context.Cities
                                        .Include(c => c.State)
                                            .ThenInclude(s => s.Country)
                                        .ToList();
                    foreach (var city in cities)
                    {
                        Console.WriteLine($"City ID: {city.CityId}, Name: {city.CityName}, State: {city.State.StateName}, Country: {city.State.Country.CountryName}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}