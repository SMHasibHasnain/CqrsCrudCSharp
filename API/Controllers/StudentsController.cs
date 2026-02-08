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
        return Ok(students);
    }

    [HttpGet("details")]
    public async Task<ActionResult<Student>> GetStudentById([FromQuery]string id)
    {
        var student = await context.Students.FindAsync(id);
        
        if(student == null)
        {
            return NotFound();
        }

        return Ok(student);
    }

    [HttpPost]
    public async Task<ActionResult> AddNewStudent([FromBody] Student s)
    {
        if(s == null) return BadRequest();
        await context.Students.AddAsync(s);
        await context.SaveChangesAsync();
        return Ok(s);
    }
}
