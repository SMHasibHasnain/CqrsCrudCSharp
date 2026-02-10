using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Students.Dtos;

public class CreateStudentDto
{
    [Required]
    public string Name {get; set;} = string.Empty;
    [Required]
    public string Hometown {get; set;} = string.Empty;
}
