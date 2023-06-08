using Microsoft.AspNetCore.Mvc;
using WildNature_Back.Configuration;
using WildNature_Back.LocalControllers;
using WildNature_Back.Models;

namespace WildNature_Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KingdomController : ControllerBase
    {
        protected readonly IKingdomController _kingdomController;
        public KingdomController(IKingdomController kingdomController)
        {
            this._kingdomController = kingdomController;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> CreateKingdom([FromBody] Kingdom t)
        {
            var result = await _kingdomController.Add(t);
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
        public async Task<IActionResult> EditKingdom(int id, string newName)
        {
            var result = await _kingdomController.Edit(id, newName);
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
        public async Task<IActionResult> RemoveKingdom(int id)
        {
            var result = await _kingdomController.Remove(id);
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
        public async Task<IActionResult> SelectKingdom()
        {
            var result = await _kingdomController.Select();
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
