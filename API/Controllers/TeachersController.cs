using System;
using Application.Teachers.Command;
using Application.Teachers.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TeachersController() : BaseApiController 
{



    [HttpPost("Create")]
    public async Task<ActionResult<Unit>> CreateTeacher([FromBody]CreateTeacherDto teacher)
    {
        return await Mediator.Send(new CreateTeacher.Command{ TeacherDto = teacher});    
    }
}
