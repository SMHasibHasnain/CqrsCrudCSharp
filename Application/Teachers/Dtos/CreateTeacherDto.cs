using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Teachers.Dtos;

public class CreateTeacherDto 
{
    public string Name { get; set; } = string.Empty;
    public string Hometown { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;
}
