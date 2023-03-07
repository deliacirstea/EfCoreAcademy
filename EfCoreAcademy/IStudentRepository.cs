using EfCoreAcademy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreAcademy
{
    public interface IStudentRepository
    {
        Task<int> CreateStudentAsync(Student student);
        Task UpdateStudentAsync(Student student);
        Task<Student?> GetStudentByIdAsync(int studentId);
        Task<List<Student>> GetStudentsAsync();
        Task DeleteStudentAsync(int studentId);
    }
}
