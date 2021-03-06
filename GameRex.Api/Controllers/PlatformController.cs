﻿using GameRex.Applicaton.Logic.Platform;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameRex.Api.Controllers
{
    [Route("api/[controller]")]
    public class PlatformController : Controller
    {
        private readonly IMediator _mediator;

        public PlatformController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/platform/5
        [HttpGet("{id}")]
        public async Task<string> Get()
        {
            return "sdf";
            //return await _mediator.Send(command);
        }

        // POST api/platform
        [HttpPost]
        public async Task<ICollection<PlatFormDto>> Post([FromBody] AddPlatformsCommand command)
        {
            return new List<PlatFormDto>();
            return await _mediator.Send(command);
        }
    }
}