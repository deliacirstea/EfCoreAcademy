using EfCoreAcademy.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreAcademy
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public async Task<int> CreateStudentAsync(Student student)
        {
            DbContext.Students.Add(student);
            await DbContext.SaveChangesAsync();
            return student.Id;
        }

        public async Task DeleteStudentAsync(int studentId)
        {
            var student = await DbContext.Students.FindAsync(studentId);
            if (student != null)
            {
                DbContext.Students.Remove(student);
                await DbContext.SaveChangesAsync();
            }
            throw new InvalidOperationException("Id not found");
        }

        public async Task<Student?> GetStudentByIdAsync(int studentId)
        {
            return await DbContext.Students.FindAsync(studentId);
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await DbContext.Students.ToListAsync();
        }

        public async Task UpdateStudentAsync(Student student)
        {
            DbContext.Students.Attach(student);
            DbContext.Entry(student).State = EntityState.Modified;
            await DbContext.SaveChangesAsync(); 
        }
    }
}
