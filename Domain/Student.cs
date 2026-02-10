using System;

namespace Domain;

public class Student
{
    public string Id {get; set;} = Guid.NewGuid().ToString();
    public required string Name {get; set;}
    public required string Hometown {get; set;}
    public bool IsRegular {get; set;}

}
