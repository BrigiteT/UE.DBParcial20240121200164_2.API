using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UE.DBParcial20240121200164_2.DOMAIN.Core.Entities;
using UE.DBParcial20240121200164_2.DOMAIN.Core.Interfaces;

namespace UE.DBParcial20240121200164_2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorRepository _directorRepository;

        public DirectorController(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var director = await _directorRepository.GetAll();
            return Ok(director);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var director = await _directorRepository.GetById(id);
            if (director == null) { return NotFound(); }
            return Ok(director);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Director director)
        {
            var result = await _directorRepository.Create(director);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Director director)
        {
            if (id != director.Id) { return BadRequest(); }
            var result = await _directorRepository.Update(director);
            if (!result) return BadRequest();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _directorRepository.Delete(id);
            if (!result) return BadRequest();
            return Ok(result);
        }
    }
}
