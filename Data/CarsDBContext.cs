using CarDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Data
{
    public class CarsDBContext: DbContext
    {
        public CarsDBContext(DbContextOptions<CarsDBContext> options)
            :base(options) 
        {
            
        }

        // add car table to db
        public DbSet<Car> cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(

                // add a card to the db to show on page before others are added
                new Car
                {
                    CarID = 1,
                    Mileage = 50000,
                    DateReceived = new DateTime(2022, 10, 5),
                    DateSold = new DateTime(2023, 11, 11),
                    Status = "Sold",
                    VIN = "1HGBH73JXMN10986",
                    Make = "Honda",
                    Model = "CRV",
                    Year = "2020"
                }

                );
         }
                
                
        }
    }

