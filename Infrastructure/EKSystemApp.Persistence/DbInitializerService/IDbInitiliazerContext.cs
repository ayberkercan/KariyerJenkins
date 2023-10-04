using EKSystemApp.Persistence.Context;
using Microsoft.Extensions.Configuration;

namespace EKSystemApp.Persistence.DbInitiliazers
{
    public interface IDbInitiliazerContext
    {
        Task Initialize(ApplicationDbContext context, IConfiguration configurations);
    }
}
