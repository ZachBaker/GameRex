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
    public class AddPlatformCommandHandler : IRequestHandler<AddPlatformCommand, string>
    {
        AddPlatformCommandHandler(GameRexContext context)
        {
            var gg = context.Set<Data.Access.Entities.Platform>();
        }

        public async Task<string> Handle(AddPlatformCommand request, CancellationToken cancellationToken)
        {
            return "Heawdawdo";
        }
    }
}
