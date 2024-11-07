using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Kreta.Backend.Datas.REsponses;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RendelesController : ControllerBase
    {
        private IRendelesRepo _rendelesRepo;

        public RendelesController(IRendelesRepo rendelesRepo)
        {
            _rendelesRepo = rendelesRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Rendeles? entity = new();
            if (_rendelesRepo is not null)
            {
                entity = await _rendelesRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Rendeles>? users = new();

            if (_rendelesRepo != null)
            {
                users = await _rendelesRepo.GetAll();
                return Ok(users);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateRendelesAsync(Rendeles entity)
        {
            ControllerResponse response = new();
            if (_rendelesRepo is not null)
            {
                response = await _rendelesRepo.UpdateRendelesAsync(entity);
                if (response.HasError)
                {
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAddError("Az adatok frissítés nem lehetséges!");
            return BadRequest(response);
        }
    }
}