using AutoMapper;
using HotelProject.DTOLayer.DTOs.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WepApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room,RoomAddDto>();
            CreateMap<RoomUpdateDto, Room>();
            CreateMap<Room, RoomUpdateDto>();
     

        }
    }
}
