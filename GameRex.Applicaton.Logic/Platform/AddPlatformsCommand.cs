using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameRex.Applicaton.Logic.Platform
{
    public class AddPlatformsCommand : IRequest<ICollection<PlatFormDto>>
    {
        public ICollection<PlatFormDto> Platforms { get; set; }
    }
}
