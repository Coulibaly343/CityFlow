using System.Collections.Generic;
using System.Linq;
using CityFlow.Core.Entity;
using CityFlow.Core.Entity.Enums;

namespace CityFlow.Infrastructure.Data
{
    public class DbInitializer
    {
        private readonly List<Vehicle> _vehicles = new List<Vehicle>();
        private readonly List<Company> _companies = new List<Company>();

        public static void Initialize(CityFlowContext context)
        {
            var initializer = new DbInitializer();
            initializer.Seed(context);
        }

        public void Seed(CityFlowContext context)
        {
            SeedUsers(context);
            SeedVehicles(context);
            SeedCompanies(context);
            SeedCity(context);
        }

        public void SeedUsers(CityFlowContext context)
        {
            var user =
                context.Users.SingleOrDefault(x => x.FirstName == "John");

            if (user is null)
            {
                user = new User()
                {
                    FirstName = "John",
                    LastName = "Adams",
                    Latitude = "50.064752",
                    Longitude = "19.944520",
                    MarkerType = MarkerTypeEnum.User,
                    Address = new Address()
                    {
                        StreetNumber = "6",
                        HouseNumber = "38",
                        Street = "Długa",
                        ZipCode = "31-988",
                        Country = "Poland"
                    }
                };
                context.Add(user);
                context.SaveChanges();
            }
        }

        public void SeedVehicles(CityFlowContext context)
        {
            var vehicle1 =
                context.Vehicles.SingleOrDefault(x => x.Name == "Trafficar");

            if (vehicle1 is null)
            {
                vehicle1 = new Vehicle()
                {
                    Name = "TraffiCar",
                    PricePerKilometer = 1.80m,
                    MarkerType = MarkerTypeEnum.TraffiCar,
                    Type = VehicleTypeEnum.Car,
                    GearBoxType = GearBoxTypeEnum.Automatic,
                    IsAvailiable = true,
                    Description = "Your car for save drive to home.",
                    NumberOfSeats = 5,
                    Latitude = "50.066068",
                    Longitude = "19.944332"
                };
                context.Add(vehicle1);
                _vehicles.Add(vehicle1);
            }

            var vehicle2 = context.Vehicles.SingleOrDefault(x => x.Name == "Blinkee");

            if (vehicle2 is null)
            {
                vehicle2 = new Vehicle()
                {
                    Name = "Blinkee",
                    PricePerKilometer = 1.00m,
                    MarkerType = MarkerTypeEnum.Blinkee,
                    Type = VehicleTypeEnum.Scooter,
                    GearBoxType = GearBoxTypeEnum.Automatic,
                    IsAvailiable = true,
                    Description = "Nexet generation of transport. ECOFriendly.",
                    NumberOfSeats = 2,
                    Latitude = "50.065021",
                    Longitude = "19.950654"
                };
                context.Add(vehicle2);
                _vehicles.Add(vehicle2);
            }

            var vehicle3 = context.Vehicles.SingleOrDefault(x => x.Name == "Uber");

            if (vehicle3 is null)
            {
                vehicle3 = new Vehicle()
                {
                    Name = "Uber",
                    PricePerKilometer = 1.90m,
                    MarkerType = MarkerTypeEnum.Uber,
                    Type = VehicleTypeEnum.Car,
                    GearBoxType = GearBoxTypeEnum.Automatic,
                    IsAvailiable = true,
                    Description = "Your driver is near.Take a drive to home.",
                    NumberOfSeats = 2,
                    Latitude = "50.065573",
                    Longitude = "19.935364"
                };
                context.Add(vehicle3);
                _vehicles.Add(vehicle3);
            }

            var vehicle4 = context.Vehicles.SingleOrDefault(x => x.Name == "Taxify");

            if (vehicle4 is null)
            {
                vehicle4 = new Vehicle()
                {
                    Name = "Taxify",
                    PricePerKilometer = 1.70m,
                    MarkerType = MarkerTypeEnum.Taxify,
                    Type = VehicleTypeEnum.Car,
                    GearBoxType = GearBoxTypeEnum.Automatic,
                    IsAvailiable = true,
                    Description = "Get your cheap ride to home.",
                    NumberOfSeats = 5,
                    Latitude = "50.062832",
                    Longitude = "19.945749"
                };
                context.Add(vehicle4);
                _vehicles.Add(vehicle4);
            }

            var vehicle5 = context.Vehicles.SingleOrDefault(x => x.Name == "Wavelo");

            if (vehicle5 is null)
            {
                vehicle5 = new Vehicle()
                {
                    Name = "Wavelo",
                    PricePerKilometer = 1.70m,
                    MarkerType = MarkerTypeEnum.Wavelo,
                    Type = VehicleTypeEnum.Bicycyle,
                    GearBoxType = GearBoxTypeEnum.None,
                    IsAvailiable = true,
                    Description = "Healthy means of transport.",
                    NumberOfSeats = 1,
                    Latitude = "50.065125",
                    Longitude = "19.943389"
                };
                context.Add(vehicle5);
                _vehicles.Add(vehicle5);
            }

            context.SaveChanges();
        }

        public void SeedCompanies(CityFlowContext context)
        {
            var company1 =
                context.Companies.SingleOrDefault(x => x.Name == "Sixt Rent a Car - Krakow Meet&Greet");

            if (company1 is null)
            {
                company1 = new Company()
                {
                    Name = "Sixt Rent a Car - Krakow Meet&Greet",
                    Latitude = "50.060827",
                    Longitude = "19.944591",
                    AvailiableVehicleType = VehicleTypeEnum.Car
                };
                context.Add(company1);
                _companies.Add(company1);
            }

            var company2 = context.Companies.SingleOrDefault(x => x.Name == "OSEK Rent a Car");

            if (company2 is null)
            {
                company2 = new Company()
                {
                    Name = "OSEK Rent a Car",
                    Latitude = "50.060136",
                    Longitude = "19.939259",
                    AvailiableVehicleType = VehicleTypeEnum.Car
                };
                context.Add(company2);
                _companies.Add(company2);
            }

            var company3 = context.Companies.SingleOrDefault(x => x.Name == "Mastercar");

            if (company3 is null)
            {
                company3 = new Company()
                {
                    Name = "Mastercar",
                    Latitude = "50.065515",
                    Longitude = "19.945106",
                    AvailiableVehicleType = VehicleTypeEnum.Car
                };
                context.Add(company3);
                _companies.Add(company3);
            }

            context.SaveChanges();
        }

        public void SeedCity(CityFlowContext context)
        {
            var city =
                context.Cities.SingleOrDefault(x => x.Name == "Cracow");

            if (city is null)
            {
                city = new City()
                {
                    Name = "Cracow",
                    Vehicles = _vehicles,
                    Companies = _companies
                };
                context.Add(city);
            }

            context.SaveChanges();
        }
    }
}
