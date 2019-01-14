using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameRex.Applicaton.Logic.Company
{
    public class AddCompaniesCommand : IRequest<string>
    {
        public ICollection<CompanyDto> Companies { get; set; }
    }
}
