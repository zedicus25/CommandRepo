using Microsoft.AspNetCore.Mvc;
using WildNature_Back.Configuration;
using WildNature_Back.LocalControllers;
using WildNature_Back.Models;

namespace WildNature_Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FamilyController : ControllerBase
    {
        private readonly IFamilyController _familyController;

        public FamilyController(IFamilyController familyController)
        {
            _familyController = familyController;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> CreateFamily([FromBody] Family t)
        {
            var result = await _familyController.Add(t);
            if (result != null)
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
        public async Task<IActionResult> EditFamily(int id, string newName)
        {
            var result = await _familyController.Edit(id, newName);
            if (result != null)
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
        public async Task<IActionResult> RemoveFamily(int id)
        {
            var result = await _familyController.Remove(id);
            if (result != null)
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
        public async Task<IActionResult> SelectFamily()
        {
            var result = await _familyController.Select();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
