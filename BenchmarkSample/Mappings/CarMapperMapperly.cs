using MappingSample.Dtos;
using MappingSample.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSample.Mappings;

[Mapper]
public partial class CarMapperMapperly
{
    [MapProperty(nameof(Car.Make), nameof(CarDto.Make))]
    [MapProperty(nameof(Car.Model), nameof(CarDto.ModelName))]
    [MapProperty(nameof(Car.Year), nameof(CarDto.Year))]
    [MapProperty(nameof(Car.Color), nameof(CarDto.Color))]
    [MapProperty(nameof(Car.Price), nameof(CarDto.Price))]
    [MapProperty(nameof(Car.Transmission), nameof(CarDto.TransmissionType))]
    [MapProperty(nameof(Car.Fuel), nameof(CarDto.FuelType))]
    [MapProperty(nameof(Car.Body), nameof(CarDto.BodyType))]
    [MapProperty(nameof(Car.SerialNumbers), nameof(CarDto.SerialNumberData))]
    [MapProperty(nameof(Car.Features), nameof(CarDto.FeatureList))]
    [MapProperty(nameof(Car.Options), nameof(CarDto.Options))]
    [MapProperty(nameof(Car.ManufactureDate), nameof(CarDto.ManufactureDate))]
    [MapProperty(nameof(Car.WarrantyPeriod), nameof(CarDto.WarrantyPeriod))]
    [MapProperty(nameof(Car.IsFourWheelDrive), nameof(CarDto.IsFourWheelDrive))]
    [MapProperty(nameof(Car.OwnerInfo), nameof(CarDto.OwnerDetails))]
    public partial CarDto CartoCarDto(Car car);


    [MapProperty(nameof(Engine.Horsepower), nameof(EngineDto.HP))]
    public partial EngineDto EnginetoEngineDto(Engine engine);


    [MapProperty(nameof(Owner.ContactNumber), nameof(OwnerDto.PhoneNumber))]
    public partial OwnerDto OwnertoOwnerDto(Owner owner);

}
