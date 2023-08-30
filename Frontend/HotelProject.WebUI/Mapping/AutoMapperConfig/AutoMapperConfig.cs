using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.BookingDtos;
using HotelProject.WebUI.Dtos.LoginDtos;
using HotelProject.WebUI.Dtos.NewsDtos;
using HotelProject.WebUI.Dtos.RegisterDtos;
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
            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();

            CreateMap<CreateNewsDto,Subscribe>().ReverseMap(); 

            CreateMap<CreateBookingDto,Booking>().ReverseMap();
        }
    }
}
