using System;
using Domain;
using AutoMapper;
using Application.Students.Dtos;

namespace Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Student, Student>();
        CreateMap<CreateStudentDto, Student>();
    }

}
