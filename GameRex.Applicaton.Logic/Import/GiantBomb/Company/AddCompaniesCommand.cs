using MediatR;
using System.Collections.Generic;

namespace GameRex.Applicaton.Logic.Company
{
    public class AddCompaniesCommand : IRequest<string>
    {
        public ICollection<CompanyDto> Companies { get; set; }
    }
}