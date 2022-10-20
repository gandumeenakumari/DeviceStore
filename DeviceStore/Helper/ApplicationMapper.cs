using AutoMapper;
using DeviceStore.Data;
using DeviceStore.Models;
namespace DeviceStore.Helper
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Mobile, MobileModel>().ReverseMap();
        }
    }
}
