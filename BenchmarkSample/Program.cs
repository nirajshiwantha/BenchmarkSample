using System;
using System.Collections.Generic;
using System.Text.Json;
using AutoMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using MappingSample.Dtos;
using MappingSample.Mappings;
using MappingSample.Models;
using Mapster;

[MemoryDiagnoser]
public class BenchmarkMappings
{
    private readonly Engine _engine;
    private readonly Owner _owner;
    private readonly Car _car;

    public BenchmarkMappings()
    {
        _engine = new Engine
        {
            Type = "V8",
            Horsepower = 350
        };

        _owner = new Owner
        {
            Name = "Niraj Ranasinghe",
            ContactNumber = "94123456789",
            PurchaseDate = DateTime.Now
        };

        _car = new Car
        {
            Id = 100,
            Make = "Honda",
            Model = "Accord",
            Year = 2023,
            Color = "Blue",
            Price = 30000,
            Engine = _engine,
            Transmission = TransmissionType.Automatic,
            Fuel = FuelType.Hybrid,
            Body = BodyStyle.Sedan,
            SerialNumbers = new[] { 12345, 67890 },
            Features = new List<string> { "Navigation system", "Leather seats", "Sunroof" },
            Options = new Dictionary<string, string>
            {
                { "Color", "Blue" },
                { "Interior", "Black" },
                { "Wheels", "18-inch alloy" }
            },
            ManufactureDate = new DateTime(2023, 3, 15),
            WarrantyPeriod = TimeSpan.FromDays(365),
            IsFourWheelDrive = false,
            OwnerInfo = _owner
        };
    }

    [Benchmark]
    public void Mapperly()
    {
        var mapper = new CarMapperMapperly();
        CarDto carDto1 = mapper.CartoCarDto(_car);
        carDto1.EngineData = mapper.EnginetoEngineDto(_engine);
        carDto1.OwnerDetails = mapper.OwnertoOwnerDto(_owner);
        JsonSerializer.Serialize(carDto1, new JsonSerializerOptions
        {
            WriteIndented = true,
            IndentCharacter = '\t',
            IndentSize = 1
        });
    }

    [Benchmark]
    public void Mapster()
    {
        var mapperMapster = new CarMapperMapster();
        mapperMapster.ConfigureMapster();
        var carDto2 = _car.Adapt<CarDto>();
        JsonSerializer.Serialize(carDto2, new JsonSerializerOptions
        {
            WriteIndented = true,
            IndentCharacter = '\t',
            IndentSize = 1
        });
    }

    [Benchmark]
    public void AutoMapper()
    {
        CarMapperAutoMapper carMapperAutoMapper = new CarMapperAutoMapper();
        IMapper autoMapper = new Mapper(carMapperAutoMapper.ConfigureAutoMapper());
        CarDto carDto3 = autoMapper.Map<CarDto>(_car);
        JsonSerializer.Serialize(carDto3, new JsonSerializerOptions
        {
            WriteIndented = true,
            IndentCharacter = '\t',
            IndentSize = 1
        });
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<BenchmarkMappings>();
    }
}
