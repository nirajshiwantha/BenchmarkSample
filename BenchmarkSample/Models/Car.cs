namespace MappingSample.Models;
public class Car
{
    public int Id { get; set; }
    public string Make { get; set; }
    public required string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public required double Price { get; set; }
    public Engine Engine { get; set; }
    public TransmissionType Transmission { get; set; }
    public FuelType Fuel { get; set; }
    public BodyStyle Body { get; set; }
    public required int[] SerialNumbers { get; set; }
    public List<string> Features { get; set; }
    public Dictionary<string, string> Options { get; set; }
    public DateTime ManufactureDate { get; set; }
    public TimeSpan WarrantyPeriod { get; set; }
    public bool IsFourWheelDrive { get; set; }
    public Owner OwnerInfo { get; set; }
}

public class Engine
{
    public string Type { get; set; }
    public double Horsepower { get; set; }
}

public class Owner
{
    public string Name { get; set; }
    public string ContactNumber { get; set; }
    public DateTime PurchaseDate { get; set; }
}

public enum TransmissionType
{
    Manual = 1,
    Automatic = 2
}

public enum FuelType
{
    Gasoline = 1,
    Diesel = 2,
    Electric = 3,
    Hybrid = 4
}

public enum BodyStyle
{
    Sedan = 1,
    SUV = 2,
    Coupe = 3,
    Convertible = 4,
    Hatchback = 5,
    PickupTruck = 6
}


