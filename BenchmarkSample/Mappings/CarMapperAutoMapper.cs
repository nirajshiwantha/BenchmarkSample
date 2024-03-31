using AutoMapper;
using AutoMapper.Features;
using MappingSample.Dtos;
using MappingSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSample.Mappings;

public class CarMapperAutoMapper
{
    public MapperConfiguration ConfigureAutoMapper() {

        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Car, CarDto>()
                .ForMember(dest => dest.ModelName, opt => opt.MapFrom(src => src.Model))
                .ForMember(dest => dest.EngineData, opt => opt.MapFrom(src => src.Engine))
                .ForMember(dest => dest.TransmissionType, opt => opt.MapFrom(src => src.Transmission))
                .ForMember(dest => dest.FuelType, opt => opt.MapFrom(src => src.Fuel))
                .ForMember(dest => dest.BodyType, opt => opt.MapFrom(src => src.Body))
                .ForMember(dest => dest.FeatureList, opt => opt.MapFrom(src => src.Features))
                .ForMember(dest => dest.SerialNumberData, opt => opt.MapFrom(src => src.SerialNumbers))
                .ForMember(dest => dest.OwnerDetails, opt => opt.MapFrom(src => src.OwnerInfo));
            cfg.CreateMap<Engine, EngineDto>()
                .ForMember(dest => dest.HP, opt => opt.MapFrom(src => src.Horsepower));
            cfg.CreateMap<Owner, OwnerDto>()
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.ContactNumber));
            cfg.CreateMap<TransmissionType, TransmissionTypeDto>();
            cfg.CreateMap<FuelType, FuelTypeDto>();
            cfg.CreateMap<BodyStyle, BodyStyleDto>();
        });

        return config;
    }
}
