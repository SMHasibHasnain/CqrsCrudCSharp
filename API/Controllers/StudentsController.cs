using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain;
using MediatR;
using Application.Students.Queries;
using Application.Students.Commands;
using Application.Students.Dtos;

namespace API.Controllers;

public class StudentsController() : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetAllStudents() {
        return await Mediator.Send(new GetStudentsList.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetStudentById([FromRoute]string id)
    {
        var student = await Mediator.Send(new GetStudentById.Query{Id = id});
        if(student == null) return NotFound();
        return Ok(student);
    }

    [HttpPut("modify")]
    public async Task<ActionResult<Unit>> ModifyStudentDetails([FromBody]Student student) {
        return await Mediator.Send(new ModifyStudent.Command{Student = student});
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Unit>> DeleteStudentById([FromRoute] string id)
    {
        return await Mediator.Send(new DeleteById.Command{Id = id});
    }

    [HttpPost("create")]
    public async Task<ActionResult<Unit>> CreateStudent([FromBody]CreateStudentDto student) {
        return await Mediator.Send(new CreateStudent.Command{StudentDto = student});
    }
}
