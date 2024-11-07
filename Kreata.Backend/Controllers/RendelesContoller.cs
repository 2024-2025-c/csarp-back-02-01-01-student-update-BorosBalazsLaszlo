﻿using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

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
}