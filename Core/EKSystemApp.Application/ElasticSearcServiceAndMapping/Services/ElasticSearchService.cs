using EKSystemApp.Application.ElasticSearcServiceAndMapping.Mapping;
using EKSystemApp.Application.Interfaces.IElasticSearchService;
using Microsoft.Extensions.Configuration;
using Nest;

namespace EKSystemApp.Application.ElasticSearcServiceAndMapping.Services
{
    public class ElasticSearchService<T> : IElasticSearchService<T> where T : class, new()
    {
        private readonly IConfiguration _configuration;
        private readonly IElasticClient _client;
        public ElasticSearchService(IConfiguration configuration)
        {
            _configuration = configuration;
            _client = CreateInstance();
        }
        private ElasticClient CreateInstance()
        {
            string host = _configuration.GetSection("ElasticsearchServer:Host").Value!;
            string port = _configuration.GetSection("ElasticsearchServer:Port").Value!;
            string username = _configuration.GetSection("ElasticsearchServer:Username").Value!;
            string password = _configuration.GetSection("ElasticsearchServer:Password").Value!;
            var settings = new ConnectionSettings(new Uri(host + ":" + port));
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                settings.BasicAuthentication(username, password);
            return new ElasticClient(settings);
        }
        public async Task ChekIndex(string indexName)
        {
            var anyy = await _client.Indices.ExistsAsync(indexName);
            if (anyy.Exists)
                return;
            var response = await _client.Indices.CreateAsync(indexName,
                ci => ci
                    .Index(indexName)
                    .Settings(s => s.NumberOfShards(3).NumberOfReplicas(1))
                    );
            return;
        }
        public async Task DeleteByIdDocument(string indexName, T entity)
        {
            var response = await _client.CreateAsync(entity, q => q.Index(indexName));
            if (response.ApiCall?.HttpStatusCode == 409)
            {
                await _client.DeleteAsync(DocumentPath<T>.Id(entity).Index(indexName));
            }
        }
        public async Task DeleteIndex(string indexName)
        {
            await _client.Indices.DeleteAsync(indexName);
        }
        public async Task<T> GetDocument(string indexName, string id)
        {
            var response = await _client.GetAsync<T>(id, q => q.Index(indexName));
            return response.Source;
        }
        public async Task<List<T>> GetDocuments(string indexName)
        {
            #region Wildcard aradaki harfi kendi tamamlıyor            
            //var response = await _client.SearchAsync<Cities>(s => s
            //        .From(0)
            //        .Take(10)
            //        .Index(indexName)
            //        .Query(q => q
            //        .Bool(b => b
            //        .Should(m => m
            //        .Wildcard(w => w
            //        .Field("city")
            //        .Value("r*ze"))))));
            #endregion

            #region Fuzzy kelime kendi tamamlar parametrikde olabilir
            //var response = await _client.SearchAsync<Cities>(s => s
            //                  .Index(indexName)
            //                  .Query(q => q
            //        .Fuzzy(fz => fz.Field("city")
            //            .Value("anka").Fuzziness(Fuzziness.EditDistance(4))
            //        )
            //    ));
            //harflerin yer değiştirmesi
            //var response = await _client.SearchAsync<Cities>(s => s
            //                  .Index(indexName)
            //                  .Query(q => q
            //        .Fuzzy(fz => fz.Field("city")
            //            .Value("rie").Transpositions(true))
            //        ));
            #endregion

            #region MatchPhrasePrefix  aradaki harfi kendi tamamlıyor Wildcard göre performans olarak daha yüksek
            //var response = await _client.SearchAsync<Cities>(s => s
            //                    .Index(indexName)
            //                    .Query(q => q.MatchPhrasePrefix(m => m.Field(f => f.City).Query("iz").MaxExpansions(10)))
            //                   );
            #endregion

            #region MultiMatch çoklu  büyük küçük duyarlığı olmaz
            // MultiMatch
            //    var response = await _client.SearchAsync<Cities>(s => s
            //                   .Index(indexName)
            //                   .Query(q => q
            //.MultiMatch(mm => mm
            //    .Fields(f => f
            //        .Field(ff => ff.City)
            //        .Field(ff => ff.Region)
            //    )
            //    .Type(TextQueryType.PhrasePrefix)
            //    .Query("iz")
            //    .MaxExpansions(10)
            //)));
            #endregion

            #region Term burada tamamı küçük harf olmalı
            //var response = await _client.SearchAsync<Cities>(s => s
            //                    .Index(indexName)
            //                  .Size(10000)
            //                   .Query(query => query.Term(f => f.City, "rize"))
            //                   );
            #endregion

            #region Match büyük küçük duyarlığı olmaz
            //var response = await _client.SearchAsync<Cities>(s => s
            //                      .Index(indexName)
            //                    .Size(10000)
            //                    .Query(q => q
            //                    .Match(m => m.Field("city").Query("ankara")
            //                     )));
            #endregion

            #region AnalyzeWildcard like sorgusu mantıgında çalışmakta
            var response = await _client.SearchAsync<T>(s => s
                                  .Index(indexName)
                                        .Query(q => q));
            #endregion         
            return response.Documents.ToList();
        }
        public async Task InsertBulkDocuments(string indexName, List<T> entity)
        {
            var k = await _client.IndexManyAsync(entity, index: indexName);
            Console.Write(k);
        }
        public async Task InsertDocument(string indexName, T entity)
        {
            var response = await _client.CreateAsync(entity, q => q.Index(indexName));
            if (response.ApiCall?.HttpStatusCode == 409)
            {
                await _client.UpdateAsync<T>(entity, a => a.Index(indexName).Doc(entity));
            }
        }
    }
}