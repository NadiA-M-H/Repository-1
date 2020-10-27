using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mintapi.Model;

namespace mintapi.Data{
    public class StudentRepository : IStudentManagementRepository<Student>
    {
        private readonly DataContext _context;
        public Task<bool> Delete(Student t)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Student>> GetAll()
        {
            return await _context.Student.ToListAsync();
        }

        public Task<Student> GetById(string Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Student> Update(Student t)
        {
            throw new System.NotImplementedException();
        }
    }
}