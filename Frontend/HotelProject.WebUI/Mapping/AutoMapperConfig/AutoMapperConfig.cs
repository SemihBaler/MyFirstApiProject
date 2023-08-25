
using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos;
using HotelProject.WebUI.Dtos.ServiceDtos;
using HotelProject.WebUI.Dtos.StaffDtos;

namespace HotelProject.WebUI.Mapping.AutoMapperConfig
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();   
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<AddStaffDto, Staff>().ReverseMap();
            CreateMap<StaffDto, Staff>().ReverseMap();
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();
        }
    }
}
