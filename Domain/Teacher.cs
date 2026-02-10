using System;

namespace Domain;

public class Teacher
{
    public string Id { get; set; } = Guid.CreateVersion7().ToString();
    public required string Name { get; set; }
    public required string Hometown { get; set; }
    public required string MobileNumber { get; set; }

}
