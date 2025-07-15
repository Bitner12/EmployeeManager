using WebApplication1.Enties;
using WebApplication1.Models.Request;

namespace EmployeeManager.Repositories
{
    public interface IHourRepository
    {
        Task<Hour> Create(HourRequest hour);
        Task<int> Delete(int id, DateTime date);
        Task<int> Update(int id, float hours, DateTime date);
    }
}