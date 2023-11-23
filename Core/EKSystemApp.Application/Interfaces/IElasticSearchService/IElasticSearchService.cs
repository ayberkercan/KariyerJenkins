namespace EKSystemApp.Application.Interfaces.IElasticSearchService
{
    public interface IElasticSearchService<T> where T : class, new()
    {
        Task ChekIndex(string indexName);
        Task InsertDocument(string indexName, T entity);
        Task DeleteIndex(string indexName);
        Task DeleteByIdDocument(string indexName, T entity);
        Task InsertBulkDocuments(string indexName, List<T> entity);
        Task<T> GetDocument(string indexName, string id);
        Task<List<T>> GetDocuments(string indexName);
    }
}
//IElasticSearchService<T> Index(string indexName);
//Task<BulkResponse> AddOrUpdateBulk(IEnumerable<T> documents);
//Task<T> AddOrUpdate(T document);
//Task<BulkResponse> AddBulk(IList<T> documents);
//Task<GetResponse<T>> Get(string key);
//Task<ISearchResponse<T>?> Query(SearchDescriptor<T> sd);
//Task<bool> Remove(string key);
//Task<DeleteByQueryResponse> BulkRemove(IDeleteByQueryRequest<T> queryReq);