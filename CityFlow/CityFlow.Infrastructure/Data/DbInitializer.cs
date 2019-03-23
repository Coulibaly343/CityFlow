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
                    Latitude = 50.06f,
                    Longitude = 19.94f
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
                    Latitude = 50.06f,
                    Longitude = 19.94f
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
                    Latitude = 50.06f,
                    Longitude = 19.94f
                };
                context.Add(vehicle5);
                _vehicles.Add(vehicle5);
            }
        }

        public void SeedCompanies(CityFlowContext context)
        {
            var company1 =
                context.Companies.SingleOrDefault(x => x.Name == "High Class Rent Kraków");

            if (company1 is null)
            {
                company1 = new Company()
                {
                    Name = "High Class Rent Kraków",
                    Latitude = 50.06f,
                    Longitude = 19.90f,
                    AvailiableVehicleTypes = new List<VehicleTypeEnum>()
                    {
                        VehicleTypeEnum.Car,
                        VehicleTypeEnum.Scooter
                    }
                };
                context.Add(company1);
                _companies.Add(company1);
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
                };
                context.Add(vehicle5);
                _vehicles.Add(vehicle5);
            }
        }

        public void SeedCity (CityFlowContext context)
        {
            var city =
                context.Cities.SingleOrDefault(x => x.Name == "Cracow");

            if (city is null)
            {
                city = new City()
                {
                    Name = "Cracow",
                    Vehicles = _vehicles
                };
                context.Add(city);
            }
        }
    }
}
