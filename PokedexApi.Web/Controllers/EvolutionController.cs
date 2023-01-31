﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokedexApi.Domain.Dtos;
using PokedexApi.Domain.Interfaces;
using PokedexApi.Web.FormRequest;

namespace PokedexApi.Web.Controllers
{
    [ApiController]
    [Route("evolution")]
    public class EvolutionController : ControllerBase
    {
        private readonly IEvolutionRepository _repository;
        private readonly IMapper _mapper;

        public EvolutionController(IEvolutionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddAsync([FromBody] EvolutionAddFormRequest payload)
        {
            try
            {
                var result = await _repository.AddAsync(new EvolutionAddDTO
                {
                    PreEvolution = payload.PreEvolution,
                    PokemonStage = payload.PokemonStage
                });

                return Created("Evolution has been registered", result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("options")]
        public async Task<IActionResult> GetByParams([FromQuery] EvolutionAddFormRequest payload)
        {
            try
            {
                var result = await _repository.GetByParamsAsync(new EvolutionGetByParamsDTO
                {
                    PreEvolution = payload.PreEvolution,
                    PokemonStage = payload.PokemonStage
                });

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}/remove")]
        public async Task<IActionResult> Remove([FromRoute] Guid id)
        {
            try
            {
                await _repository.DeleteAsync(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
