using Microsoft.AspNetCore.Mvc;
using WildNature_Back.Configuration;
using WildNature_Back.Models;

namespace WildNature_Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenController : ControllerBase
    {
        private readonly IGenController _genController;
        public GenController(IGenController genController)
        {
            _genController = genController;
        }


        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> CreateGen([FromBody] Gen t)
        {
            var result = await _genController.Add(t);
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
        public async Task<IActionResult> EditGen(int id, string newName)
        {
            var result = await _genController.Edit(id, newName);
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
        public async Task<IActionResult> RemoveGen(int id)
        {
            var result = await _genController.Remove(id);
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
        public async Task<IActionResult> SelectGen()
        {
            var result = await _genController.Select();
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
