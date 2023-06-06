using Microsoft.AspNetCore.Mvc;
using WildNature_Back.Configuration;
using WildNature_Back.Models;

namespace WildNature_Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpeciesController : ControllerBase
    {
        private readonly ISpeciesController _speciesController;

        public SpeciesController(ISpeciesController speciesController)
        {
            this._speciesController = speciesController;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> CreateSpecies([FromBody] Species t)
        {
            var result = await _speciesController.Add(t);
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> EditSpecies(int id, string newName)
        {
            var result = await _speciesController.Edit(id, newName);
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("Remove")]
        public async Task<IActionResult> RemoveSpecies(int id)
        {
            var result = await _speciesController.Remove(id);    
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("Select")]
        public async Task<IActionResult> SelectSpecies()
        {
            var result = await _speciesController.Select();
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("SelectAnimal")]
        public async Task<IActionResult> SelectAnimalSpecies(string search)
        {
            var result = await _speciesController.Select();
            if (result != null)
            {
                if (!string.IsNullOrEmpty(search.ToLower()))
                {
                    result = result.Where(g => g.Name.Contains(search.ToLower())).ToList();
                }
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("SelectAnimalById")]
        public async Task<IActionResult> SelectAnimalIdSpecies(int id)
        {
            var result = await _speciesController.Select();
            if (result != null)
            {
                if(id > 0)
                {
                    result = result.Where(g => g.Id == id).ToList();
                }
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
