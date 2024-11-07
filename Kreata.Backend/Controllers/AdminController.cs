using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AdminController : ControllerBase
{
    private IAdminRepo _adminRepo;

    public AdminController(IAdminRepo adminRepo)
    {
        _adminRepo = adminRepo;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBy(Guid id)
    {
        Admin? entity = new();
        if (_adminRepo is not null)
        {
            entity = await _adminRepo.GetBy(id);
            if (entity != null)
                return Ok(entity);
        }
        return BadRequest("Az adatok elérhetetlenek!");
    }

    [HttpGet]
    public async Task<IActionResult> SelectAllRecordToListAsync()
    {
        List<Admin>? users = new();

        if (_adminRepo != null)
        {
            users = await _adminRepo.GetAll();
            return Ok(users);
        }
        return BadRequest("Az adatok elérhetetlenek!");
    }
}