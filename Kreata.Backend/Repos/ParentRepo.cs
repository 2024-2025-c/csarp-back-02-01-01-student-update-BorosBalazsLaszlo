using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Kreta.Backend.Datas.REsponses;
using Microsoft.EntityFrameworkCore;

public class StudentRepo : IStudentRepo
{
    private readonly KretaInMemoryContext _dbContext;

    public StudentRepo(KretaInMemoryContext dbContext)
    {

        _dbContext = dbContext;
    }

    public async Task<Student?> GetBy(Guid id)
    {

        return await _dbContext.Students.FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<List<Student>> GetAll()
    {

        return await _dbContext.Students.ToListAsync();
    }

    public async Task<ControllerResponse> UpdateStudentAsync(Student student)
    {
        ControllerResponse response = new ControllerResponse();
        _dbContext.ChangeTracker.Clear();
        _dbContext.Entry(student).State = EntityState.Modified;
        try
        {

            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            response.AddNewError(e.Message);
            response.AddNewError($"{nameof(StudentRepo)} oszt�ly, {nameof(UpdateStudentAsync)} hiba keletkezett");
            response.AddNewError($"{student} friss�t�s sikertelen!");
        }
        return response;
    }
}
}