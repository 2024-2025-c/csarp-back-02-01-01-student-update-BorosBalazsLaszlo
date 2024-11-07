using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Kreta.Backend.Datas.REsponses;
using Microsoft.EntityFrameworkCore;

public class AdminRepo : IAdminRepo
{
    private readonly KretaInMemoryContext _dbContext;

    public AdminRepo(KretaInMemoryContext dbContext)
    {

        _dbContext = dbContext;
    }

    public async Task<Admin?> GetBy(Guid id)
    {

        return await _dbContext.Admins.FirstOrDefaultAsync(p => p.A_Id == id);
    }

    public async Task<List<Admin>> GetAll()
    {

        return await _dbContext.Admins.ToListAsync();
    }

    public async Task<ControllerResponse> UpdateAdminAsync(Admin admin)
    {
        ControllerResponse response = new ControllerResponse();
        _dbContext.ChangeTracker.Clear();
        _dbContext.Entry(admin).State = EntityState.Modified;
        try
        {

            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            response.AddNewError(e.Message);
            response.AddNewError($"{nameof(AdminRepo)} osztály, {nameof(UpdateAdminAsync)} hiba keletkezett");
            response.AddNewError($"{admin} frissítés sikertelen!");
        }
        return response;
    }
}