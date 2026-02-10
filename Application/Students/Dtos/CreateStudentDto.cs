using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Students.Dtos;

public class CreateStudentDto
{
    public string Name {get; set;} = string.Empty;
    public string Hometown {get; set;} = string.Empty;
}
