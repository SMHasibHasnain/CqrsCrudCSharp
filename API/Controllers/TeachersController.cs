using System;
using Application.Teachers.Command;
using Application.Teachers.Dtos;
using Application.Teachers.Query;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TeachersController() : BaseApiController 
{

    [HttpGet("Teachers")] 
    public async Task<ActionResult<List<Teacher>>> GetAllTeacher ()
    {
        return await Mediator.Send(new GetAllStudent.Query{});
    } 

    [HttpPost("Create")]
    public async Task<ActionResult<Unit>> CreateTeacher([FromBody]CreateTeacherDto teacher)
    {
        return await Mediator.Send(new CreateTeacher.Command{ TeacherDto = teacher});    
    }
}
