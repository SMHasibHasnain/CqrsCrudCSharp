using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain;

namespace API.Controllers;

public class StudentsController(AppDbContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetAllStudents() {
        var students = await context.Students.ToListAsync();
        return students;
    }
}
