using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSample.Dtos;

public record CarDto
{
    public string Make { get; set; }
    public string ModelName { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public EngineDto EngineData { get; set; }
    public TransmissionTypeDto TransmissionType { get; set; }
    public FuelTypeDto FuelType { get; set; }
    public BodyStyleDto BodyType { get; set; }
    public int[] SerialNumberData { get; set; }
    public List<string> FeatureList { get; set; }
    public Dictionary<string, string> Options { get; set; }
    public DateTime ManufactureDate { get; set; }
    public TimeSpan WarrantyPeriod { get; set; }
    public bool IsFourWheelDrive { get; set; }
    public OwnerDto OwnerDetails { get; set; }
}

public class EngineDto
{
    public string Type { get; set; }
    public double HP { get; set; }
}

public class OwnerDto
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime PurchaseDate { get; set; }
}

public enum TransmissionTypeDto
{
    Manual = 1,
    Automatic = 2
}

public enum FuelTypeDto
{
    Gasoline = 1,
    Diesel = 2,
    Electric = 3,
    Hybrid = 4
}

public enum BodyStyleDto
{
    Sedan = 1,
    SUV = 2,
    Coupe = 3,
    Convertible = 4,
    Hatchback = 5,
    PickupTruck = 6
}