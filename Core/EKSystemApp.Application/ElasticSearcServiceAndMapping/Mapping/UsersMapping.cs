using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Domain.Entities;
using Nest;

namespace EKSystemApp.Application.ElasticSearcServiceAndMapping.Mapping
{
    public static class UsersMapping
    {
        public static CreateIndexDescriptor UserElasticMapping(this CreateIndexDescriptor descriptor)
        {
            return descriptor.Map<UsersDetailsDto>(m => m.Properties(p => p
                .Keyword(k => k.Name(n => n.Id))
                .Text(t => t.Name(n => n.FirstName))
                .Text(t => t.Name(n => n.LastName))
                .Text(t => t.Name(n => n.UserName))
                .Text(t => t.Name(n => n.Registry))
                .Text(t => t.Name(n => n.RoleName))
                .Text(t => t.Name(n => n.Companies))
            ));
        }
    }
}
