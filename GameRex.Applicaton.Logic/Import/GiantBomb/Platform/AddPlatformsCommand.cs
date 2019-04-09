using MediatR;
using System.Collections.Generic;

namespace GameRex.Applicaton.Logic.Platform
{
    public class AddPlatformsCommand : IRequest<ICollection<PlatFormDto>>
    {
        public ICollection<GiantBombPlatform> Platforms { get; set; }

        public class GiantBombPlatform
        {
            public int Id { get; set; }

            //Since data comes from different sources, we need a way to map an ID
            //back to that source
            public string Guid { get; set; }

            public string Abbreviation { get; set; }

            public string Deck { get; set; }

            public string Description { get; set; }

            public string Site_detail_url { get; set; }

            public int Install_base { get; set; }

            public string Name { get; set; }
        }
    }
}