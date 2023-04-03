using CompanyCrudBlazor.Models;

namespace CompanyCrudBlazor.Services
{
    public interface ICompanyService
    {
        public Task Add(Company company);
        public Task Update(Company company);
        public Task Delete(Company company);
        public Task<Company> GetBy(Guid id);
        public Task<List<Company>> FindAll();


    }
}
