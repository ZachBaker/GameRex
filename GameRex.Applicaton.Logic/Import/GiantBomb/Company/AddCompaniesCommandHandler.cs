using GameRex.GiantBomb.Data.Access;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GameRex.Applicaton.Logic.Company
{
    public class AddCompaniesCommandHandler : IRequestHandler<AddCompaniesCommand, string>
    {
        private DbSet<GameRex.GiantBomb.Data.Access.Entities.Company> _companies;

        private AddCompaniesCommandHandler(GameRexContext context)
        {
            _companies = context.Set<GiantBomb.Data.Access.Entities.Company>();
        }

        public Task<string> Handle(AddCompaniesCommand request, CancellationToken cancellationToken)
        {
            _companies.AddRange();

            throw new NotImplementedException();
        }
    }
}