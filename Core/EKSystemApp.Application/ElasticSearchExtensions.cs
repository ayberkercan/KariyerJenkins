using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.Eba;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
namespace EKSystemApp.Application
{
    public static class ElasticSearchExtensions
    {
        public static void AddElasticSearch(this IServiceCollection services,IConfiguration configuration)
        {
            var url = configuration["ElasticConfiguration:Uri"];
            var defaultIndex = configuration["ElasticConfiguration:index"];
            var settings = new ConnectionSettings(new Uri(url))
            .PrettyJson()
            .DefaultIndex(defaultIndex);
            settings.DefaultFieldNameInferrer(p => p);
            AddDefaultMappings(settings);

            var client = new ElasticClient(settings);
            services.AddSingleton<IElasticClient>(client);

            CreateIndex(client, defaultIndex);


        }
        private static void AddDefaultMappings(ConnectionSettings settings)
        {
            settings.DefaultMappingFor<AppUser>(p =>
                    p.Ignore(x => x.FirstName));
        }

        private static void CreateIndex(IElasticClient client,string indexName)
        {
            client.Indices.Create(indexName, i => i.Map<AppUser>(x => x.AutoMap()));
        }
    }


}