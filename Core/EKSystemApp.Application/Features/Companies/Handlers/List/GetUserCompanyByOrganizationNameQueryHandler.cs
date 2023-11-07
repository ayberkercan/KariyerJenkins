using AutoMapper;
using EKSystemApp.Application.DTO.Company.List;
using EKSystemApp.Application.Features.Companies.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Companies.Handlers.List
{
    public class GetUserCompanyByOrganizationNameQueryHandler : IRequestHandler<GetUserCompanyByOrganizationNameQueryRequest, ICollection<CompaniesListDto>>
    {
        private readonly IMapper mapper;
        private IGenericRepository<Company> genericRepository;
        public GetUserCompanyByOrganizationNameQueryHandler(IMapper mapper, IGenericRepository<Company> genericRepository)
        {
            this.mapper = mapper;
            this.genericRepository = genericRepository;
        }
        public async Task<ICollection<CompaniesListDto>> Handle(GetUserCompanyByOrganizationNameQueryRequest request, CancellationToken cancellationToken)
        {
            List<string> companies = new List<string>();
          
            var userCompany = request.companyName.Split(",");
            foreach (var item in userCompany)
            {
                companies.Add(item);
            }
            var data = await this.genericRepository.GetAllAsync();
            var result = NewUserCompanyReturnList(data, companies);

            return this.mapper.Map<ICollection<CompaniesListDto>>(result);
        }

        public List<Company> NewUserCompanyReturnList(ICollection<Company> companies, List<string> companyParameter)
        {
            List<Company> list = new List<Company>();
            foreach (var company in companyParameter)
            {
                switch (company)
                {
                    case "Holding":
                        var holding = GetContextCompany(companies, company);
                        foreach (var items in holding)
                        {
                            list.Add(items);
                        }
                        break;
                    case "D&R Market":
                        var drMarket = GetContextCompany(companies, company);
                        foreach (var items in drMarket)
                        {
                            list.Add(items);
                        }
                        break;
                    case "D&R":
                        var dr = GetContextCompany(companies, company);
                        foreach (var items in dr)
                        {
                            list.Add(items);
                        }
                        break;
                }
            }
            return list;
        }
        public ICollection<Company> GetContextCompany(ICollection<Company> companies , string company)
        {
            var result = companies
                            .Where(p => p.CompanyName == company)
                            .OrderByDescending(d => d)
                            .Distinct()
                            .ToList();
            return result;
        }
    }
}
