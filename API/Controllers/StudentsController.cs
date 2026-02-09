using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain;
using MediatR;
using Application.Students.Queries;

namespace API.Controllers;

public class StudentsController(IMediator mediator) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetAllStudents() {
        return await mediator.Send(new GetStudentsList.Query());
    }

    [HttpGet("details")]
    public async Task<ActionResult<Student>> GetStudentById([FromQuery]string id)
    {
        var student = await mediator.Send(new GetStudentById.Query{Id = id});
        if(student == null) return NotFound();
        return Ok(student);
    }
}
