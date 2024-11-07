using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Kreta.Backend.Datas.REsponses;
using Microsoft.EntityFrameworkCore;

public class RendelesRepo : IRendelesRepo
{
    private readonly KretaInMemoryContext _dbContext;

    public RendelesRepo(KretaInMemoryContext dbContext)
    {

        _dbContext = dbContext;
    }

    public async Task<Rendeles?> GetBy(Guid id)
    {

        return await _dbContext.Rendelesek.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<List<Rendeles>> GetAll()
    {

        return await _dbContext.Rendelesek.ToListAsync();
    }

    public async Task<ControllerResponse> UpdateRendelesAsync(Rendeles rendeles)
    {
        ControllerResponse response = new ControllerResponse();
        _dbContext.ChangeTracker.Clear();
        _dbContext.Entry(rendeles).State = EntityState.Modified;
        try
        {

            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            response.AddNewError(e.Message);
            response.AddNewError($"{nameof(RendelesRepo)} osztály, {nameof(UpdateRendelesAsync)} hiba keletkezett");
            response.AddNewError($"{rendeles} frissítés sikertelen!");
        }
        return response;
    }
}