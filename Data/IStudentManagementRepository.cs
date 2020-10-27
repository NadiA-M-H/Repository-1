using System.Collections.Generic;
using System.Threading.Tasks;
namespace mintapi.Data{
    public interface IStudentManagementRepository <T>
    {
Task<List<T>> GetAll();
Task<T> GetById(string Id);
Task<T> Update(T t);
Task<bool> Delete(T t);
    }
}