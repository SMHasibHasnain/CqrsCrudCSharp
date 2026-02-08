using System;
using Domain;
namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData (AppDbContext context)
    {
        if(context.Students.Any()) return;

        var students = new List<Student>
        {
            new Student { Name = "Tanvir Ahmed", Hometown = "Dhaka", IsRegular = true },
            new Student { Name = "Sadia Islam", Hometown = "Chittagong", IsRegular = true },
            new Student { Name = "Rakibul Hasan", Hometown = "Rajshahi", IsRegular = false },
            new Student { Name = "Farhana Akter", Hometown = "Sylhet", IsRegular = true },
            new Student { Name = "Mehedi Hasan", Hometown = "Khulna", IsRegular = true },
            new Student { Name = "Nusrat Jahan", Hometown = "Barishal", IsRegular = true },
            new Student { Name = "Abdullah Al Mamun", Hometown = "Mymensingh", IsRegular = false },
            new Student { Name = "Ayesha Siddiqua", Hometown = "Comilla", IsRegular = true },
            new Student { Name = "Sajib Roy", Hometown = "Rangpur", IsRegular = true },
            new Student { Name = "Fahim Shahriar", Hometown = "Bogura", IsRegular = true },
            new Student { Name = "Jannatul Ferdous", Hometown = "Jessore", IsRegular = false },
            new Student { Name = "Imran Hossain", Hometown = "Pabna", IsRegular = true },
            new Student { Name = "Sumaiya Khan", Hometown = "Dinajpur", IsRegular = true },
            new Student { Name = "Mahmudul Haque", Hometown = "Noakhali", IsRegular = true },
            new Student { Name = "Tasnim Rahman", Hometown = "Tangail", IsRegular = false },
            new Student { Name = "Rifat Chowdhury", Hometown = "Cox's Bazar", IsRegular = true },
            new Student { Name = "Sharmin Sultana", Hometown = "Gazipur", IsRegular = true },
            new Student { Name = "Arifur Rahman", Hometown = "Narayanganj", IsRegular = true },
            new Student { Name = "Mariya Karim", Hometown = "Faridpur", IsRegular = false },
            new Student { Name = "Zubair Ahmed", Hometown = "Kushtia", IsRegular = true }
        };

        context.Students.AddRange(students);
        await context.SaveChangesAsync();
    }
}
