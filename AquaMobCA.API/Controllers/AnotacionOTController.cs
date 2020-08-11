using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.AnotacionOTFeatures.Queries;
using Application.Features.UserFeatures.Commands;
using Application.Features.UserFeatures.Queries;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnotacionOTController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllAnotacionesOTQuery()));
        }

        [HttpGet("{idoperario}")]
        public async Task<IActionResult> GetAllOperario()
        {
            return Ok(await Mediator.Send(new GetAllAnotacionesByIdOperarioQuery()));
        }

        [HttpGet("{idorden}")]
        public async Task<IActionResult> GetAllordenTrabajo()
        {
            return Ok(await Mediator.Send(new GetAllAnotacionesOTByIdOrdenTrabajoQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Mediator.Send(new GetUserByIdQuery { Id = id }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteUserByIdCommand { Id = id }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateUserCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }
    }
}
