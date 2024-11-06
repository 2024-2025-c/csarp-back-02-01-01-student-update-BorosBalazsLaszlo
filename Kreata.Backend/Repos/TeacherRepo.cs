
using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Kreta.Backend.Datas.REsponses;
using Microsoft.EntityFrameworkCore;

public class TeacherRepo : ITeacherRepo
{
    private readonly KretaInMemoryContext _dbContext;

    public TeacherRepo(KretaInMemoryContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Teacher>> GetAll()
    {
        return await _dbContext.Teachers.ToListAsync();
    }

    public async Task<Teacher?> GetBy(Guid id)
    {
        return await _dbContext.Teachers.FirstOrDefaultAsync(t => t.Id == id);
    }
    public async Task<ControllerResponse> UpdateTeacherAsync(Teacher teacher)
    {
        ControllerResponse response = new ControllerResponse();
        _dbContext.ChangeTracker.Clear();
        _dbContext.Entry(teacher).State = EntityState.Modified;
        try
        {

            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            response.AddNewError(e.Message);
            response.AddNewError($"{nameof(TeacherRepo)} osztály, {nameof(UpdateTeacherAsync)} hiba keletkezett");
            response.AddNewError($"{teacher} frissítés sikertelen!");
        }
        return response;
    }
}