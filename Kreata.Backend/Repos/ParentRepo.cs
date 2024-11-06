using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Kreta.Backend.Datas.REsponses;
using Microsoft.EntityFrameworkCore;

public class ParentRepo : IParentRepo
{
    private readonly KretaInMemoryContext _dbContext;

    public ParentRepo(KretaInMemoryContext dbContext)
    {

        _dbContext = dbContext;
    }

    public async Task<Parent?> GetBy(Guid id)
    {

        return await _dbContext.Parents.FirstOrDefaultAsync(s => s.Sz1_Id == id);
    }

    public async Task<List<Parent>> GetAll()
    {

        return await _dbContext.Parents.ToListAsync();
    }

    public async Task<ControllerResponse> UpdateParentAsync(Parent parent)
    {
        ControllerResponse response = new ControllerResponse();
        _dbContext.ChangeTracker.Clear();
        _dbContext.Entry(parent).State = EntityState.Modified;
        try
        {

            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            response.AddNewError(e.Message);
            response.AddNewError($"{nameof(ParentRepo)} osztály, {nameof(UpdateParentAsync)} hiba keletkezett");
            response.AddNewError($"{parent} frissítés sikertelen!");
        }
        return response;
    }
}