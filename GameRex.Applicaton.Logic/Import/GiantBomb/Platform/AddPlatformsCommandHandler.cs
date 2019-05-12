using GameRex.GiantBomb.Data.Access;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GameRex.Applicaton.Logic.Platform
{
    public class AddPlatformsCommandHandler : IRequestHandler<AddPlatformsCommand, ICollection<PlatFormDto>>
    {
        private AddPlatformsCommandHandler(GameRexContext context)
        {
            var gg = context.Set<GiantBomb.Data.Access.Entities.Platform>();
        }

        public async Task<ICollection<PlatFormDto>> Handle(AddPlatformsCommand request, CancellationToken cancellationToken)
        {
            return new List<PlatFormDto>();
        }
    }
}