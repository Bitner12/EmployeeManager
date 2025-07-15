using WebApplication1.Enties;
using WebApplication1.Models.Request;
using WebApplication1.Response;

namespace WebApplication1.Repositories
{
    public interface IWorkerRepository
    {
        Task <Worker> Create(WorkerRequest worker);
        Task <int> Delete(int id);
        Task<List<Worker>> GetAllAsync();
        Task<Worker> GetById(int id);
        Task <List<Worker>> GetWorkersWithHours(string search, DateTime? startDate, DateTime? endDate);
        Task <int> Update(int id, string name, decimal costPerHour);
    }
}