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
        private readonly IGenController _genController;
        private readonly IFamilyController _familyController;
        private readonly IClassController _classController;
        private readonly IKingdomController _kingdomController;

        public SpeciesController(ISpeciesController speciesController, IGenController genController, IFamilyController familyController, IClassController classController, IKingdomController kingdomController)
        {
            _speciesController = speciesController;
            _genController = genController;
            _familyController = familyController;
            _classController = classController;
            _kingdomController = kingdomController;
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
                    var species = result.FirstOrDefault(g => g.Id == id);
                    if(species != null)
                    {
                        var _class = _classController.Select().Result.FirstOrDefault(x => x.Id == species.IdClass);
                        var _family = _familyController.Select().Result.FirstOrDefault(x => x.Id == species.IdFamily);
                        var _kingdom = _kingdomController.Select().Result.FirstOrDefault(x => x.Id == species.IdKingdom);
                        var _gen = _genController.Select().Result.FirstOrDefault(x => x.Id == species.IdGen);
                        return Ok(new { Name = species.Name, Image = species.Image, Description = species.Description, kingdom = _kingdom?.Name, family = _family?.Name, cls = _class?.Name, gen = _gen?.Name  });
                    }
                }
                return NotFound();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
