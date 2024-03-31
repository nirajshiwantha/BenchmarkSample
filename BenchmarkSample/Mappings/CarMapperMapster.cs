using MappingSample.Dtos;
using MappingSample.Mappings;
using MappingSample.Models;
using Mapster;
using System.Diagnostics;
using System.Text.Json;

namespace MappingSample.Mappings;

public class CarMapperMapster
{
    public void ConfigureMapster()
    {
        TypeAdapterConfig<Car, CarDto>.NewConfig()
            .Map(dest => dest.Make, src => src.Make)
            .Map(dest => dest.ModelName, src => src.Model)
            .Map(dest => dest.Year, src => src.Year)
            .Map(dest => dest.Color, src => src.Color)
            .Map(dest => dest.Price, src => src.Price)
            .Map(dest => dest.EngineData, src => src.Engine.Adapt<EngineDto>())
            .Map(dest => dest.TransmissionType, src => (TransmissionTypeDto)src.Transmission)
            .Map(dest => dest.FuelType, src => (FuelTypeDto)src.Fuel)
            .Map(dest => dest.BodyType, src => (BodyStyleDto)src.Body)
            .Map(dest => dest.SerialNumberData, src => src.SerialNumbers)
            .Map(dest => dest.FeatureList, src => src.Features)
            .Map(dest => dest.Options, src => src.Options)
            .Map(dest => dest.ManufactureDate, src => src.ManufactureDate)
            .Map(dest => dest.WarrantyPeriod, src => src.WarrantyPeriod)
            .Map(dest => dest.IsFourWheelDrive, src => src.IsFourWheelDrive)
            .Map(dest => dest.OwnerDetails, src => src.OwnerInfo.Adapt<OwnerDto>())
            .Map(dest => dest.OwnerDetails.PhoneNumber, src => src.OwnerInfo.ContactNumber)
            .Map(dest => dest.EngineData.Type, src => src.Engine.Type)
            .Map(dest => dest.EngineData.HP, src => src.Engine.Horsepower); 
    }
}