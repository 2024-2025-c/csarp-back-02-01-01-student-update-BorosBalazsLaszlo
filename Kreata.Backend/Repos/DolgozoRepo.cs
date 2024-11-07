using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Kreta.Backend.Datas.REsponses;
using Microsoft.EntityFrameworkCore;

public class DolgozoRepo : IDolgozoRepo
{
    private readonly KretaInMemoryContext _dbContext;

    public DolgozoRepo(KretaInMemoryContext dbContext)
    {

        _dbContext = dbContext;
    }

    public async Task<Dolgozo?> GetBy(Guid id)
    {

        return await _dbContext.Dolgozok.FirstOrDefaultAsync(p => p.D_Id == id);
    }

    public async Task<List<Dolgozo>> GetAll()
    {

        return await _dbContext.Dolgozok.ToListAsync();
    }

    public async Task<ControllerResponse> UpdateDolgozoAsync(Dolgozo dolgozo)
    {
        ControllerResponse response = new ControllerResponse();
        _dbContext.ChangeTracker.Clear();
        _dbContext.Entry(dolgozo).State = EntityState.Modified;
        try
        {

            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            response.AddNewError(e.Message);
            response.AddNewError($"{nameof(DolgozoRepo)} osztály, {nameof(UpdateDolgozoAsync)} hiba keletkezett");
            response.AddNewError($"{dolgozo} frissítés sikertelen!");
        }
        return response;
    }
}