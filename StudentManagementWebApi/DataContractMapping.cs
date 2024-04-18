using AutoMapper;
using StudentManagementWebApi.Domain;
using StudentManagementWebApi.Dto;

namespace StudentManagementWebApi
{
    public class DataContractMapping :Profile
    {
        public DataContractMapping()
        {
            CreateMap<Student, StudentDto>()
           .ForMember(d => d.Address, opt => opt.MapFrom(src => src.Address));

            CreateMap<StudentDto, Student>()
                .ForMember(d => d.Address, opt => opt.MapFrom(src => src.Address));
        }
    }
}
