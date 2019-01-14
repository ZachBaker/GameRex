using GameRex.Data.Access;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameRex.Applicaton.Logic.Platform
{
    public class AddPlatformsCommandHandler : IRequestHandler<AddPlatformsCommand, ICollection<PlatFormDto>>
    {
        AddPlatformsCommandHandler(GameRexContext context)
        {
            var gg = context.Set<Data.Access.Entities.Platform>();
        }

        public async Task<ICollection<PlatFormDto>> Handle(AddPlatformsCommand request, CancellationToken cancellationToken)
        {
            return new List<PlatFormDto>();
        }
    }
}
