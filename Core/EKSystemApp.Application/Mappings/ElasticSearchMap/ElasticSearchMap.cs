using EKSystemApp.Application.DTO.Company.List;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.Mappings.ElasticSearchMap
{
    public static class ElasticSearchMap
    {
        public static CreateIndexDescriptor PositionMapping(this CreateIndexDescriptor descriptor)
        {
            return descriptor.Map<CompaniesListDto>(x => x.Properties(y => y
            .Keyword(t => t.Name(n => n.Id))
            .Keyword(t => t.Name(n => n.MenuId))
            .Keyword(t => t.Name(n => n.AppUserCompanies))
            .Keyword(t => t.Name(n => n.CompanyName))
            .Keyword(t => t.Name(n => n.Menu))
            .Keyword(t => t.Name(n => n.MenuId))
            ));
        }
    }
}
