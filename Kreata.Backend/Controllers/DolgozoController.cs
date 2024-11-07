using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Kreta.Backend.Datas.REsponses;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DolgozoController : ControllerBase
    {
        private IDolgozoRepo _dolgozoRepo;

        public DolgozoController(IDolgozoRepo dolgozoRepo)
        {
            _dolgozoRepo = dolgozoRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Dolgozo? entity = new();
            if (_dolgozoRepo is not null)
            {
                entity = await _dolgozoRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Dolgozo>? users = new();

            if (_dolgozoRepo != null)
            {
                users = await _dolgozoRepo.GetAll();
                return Ok(users);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateDolgozoAsync(Dolgozo entity)
        {
            ControllerResponse response = new();
            if (_dolgozoRepo is not null)
            {
                response = await _dolgozoRepo.UpdateDolgozoAsync(entity);
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