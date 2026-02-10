using System;
using Domain;
namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData (AppDbContext context)
    {

        if(context.Teachers.Any()) return; 

        var teachers = new List<Teacher>
        {
            new() { Name = "Abdullah Al Mamun", Hometown = "Dhaka", MobileNumber = "01712345678" },
            new() { Name = "Fatema Tuz Zohra", Hometown = "Chittagong", MobileNumber = "01812345679" },
            new() { Name = "Mehedi Hasan", Hometown = "Rajshahi", MobileNumber = "01712345680" },
            new() { Name = "Sadia Afrin", Hometown = "Sylhet", MobileNumber = "01712345681" },
            new() { Name = "Rakib Hossain", Hometown = "Khulna", MobileNumber = "01912345682" },
            new() { Name = "Nusrat Jahan", Hometown = "Barisal", MobileNumber = "01612345683" },
            new() { Name = "Sabbir Ahmed", Hometown = "Comilla", MobileNumber = "01812345684" },
            new() { Name = "Ayesha Siddiqua", Hometown = "Mymensingh", MobileNumber = "01712345685" },
            new() { Name = "Tanvir Islam", Hometown = "Rangpur", MobileNumber = "01712345686" },
            new() { Name = "Jannatul Ferdous", Hometown = "Bogra", MobileNumber = "01712345687" },
            new() { Name = "Ariful Islam", Hometown = "Jessore", MobileNumber = "01912345688" },
            new() { Name = "Farhana Akter", Hometown = "Pabna", MobileNumber = "01712345689" },
            new() { Name = "Imran Hossain", Hometown = "Tangail", MobileNumber = "01712345690" },
            new() { Name = "Sumaiya Sharmin", Hometown = "Faridpur", MobileNumber = "01612345691" },
            new() { Name = "Mahfuzur Rahman", Hometown = "Dinajpur", MobileNumber = "01712345692" },
            new() { Name = "Rubina Khan", Hometown = "Kushtia", MobileNumber = "01712345693" },
            new() { Name = "Sohel Rana", Hometown = "Gazipur", MobileNumber = "01912345694" },
            new() { Name = "Tasnim Tabassum", Hometown = "Narayanganj", MobileNumber = "01812345695" },
            new() { Name = "Kamrul Hasan", Hometown = "Noakhali", MobileNumber = "01812345696" },
            new() { Name = "Nazmun Nahar", Hometown = "Feni", MobileNumber = "01612345697" },
            new() { Name = "Shakil Ahmed", Hometown = "Cox's Bazar", MobileNumber = "01812345698" },
            new() { Name = "Mariya Sultana", Hometown = "Brahmanbaria", MobileNumber = "01712345699" },
            new() { Name = "Jubayer Ahmed", Hometown = "Jamalpur", MobileNumber = "01912345700" },
            new() { Name = "Sharmin Akter", Hometown = "Sherpur", MobileNumber = "01712345701" },
            new() { Name = "Rashedul Islam", Hometown = "Natore", MobileNumber = "01712345702" },
            new() { Name = "Umme Kulsum", Hometown = "Sirajganj", MobileNumber = "01712345703" },
            new() { Name = "Mijanur Rahman", Hometown = "Naogaon", MobileNumber = "01712345704" },
            new() { Name = "Salma Begum", Hometown = "Chapainawabganj", MobileNumber = "01712345705" },
            new() { Name = "Foysal Ahmed", Hometown = "Habiganj", MobileNumber = "01712345706" },
            new() { Name = "Rumana Yeasmin", Hometown = "Maulvibazar", MobileNumber = "01712345707" }
        };

        context.Teachers.AddRange(teachers);
        await context.SaveChangesAsync();

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
