using GameRex.Data.Access;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameRex.Applicaton.Logic.Company
{
    public class AddCompaniesCommandHandler : IRequestHandler<AddCompaniesCommand, string>
    {
        private DbSet<Data.Access.Entities.Company> _companies;

        AddCompaniesCommandHandler(GameRexContext context)
        {
           _companies = context.Set<Data.Access.Entities.Company>();
        }

        public Task<string> Handle(AddCompaniesCommand request, CancellationToken cancellationToken)
        {
            _companies.AddRange();

            throw new NotImplementedException();
        }
    }
}
