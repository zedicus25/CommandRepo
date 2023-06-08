using Microsoft.AspNetCore.Mvc;
using WildNature_Back.Configuration;
using WildNature_Back.Models;

namespace WildNature_Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IClassController _classController;

        public ClassController(IClassController classController)
        {
            _classController = classController;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> CreateClass([FromBody]Class t)
        {
            var result = await _classController.Add(t);
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
        public async Task<IActionResult> EditClass(int id, string newName)
        {
            var result = await _classController.Edit(id, newName);
            if( result != null)
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
        public async Task<IActionResult> RemoveClass(int id)
        {
            var result = await _classController.Remove(id);
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
        public async Task<IActionResult> SelectClass()
        {
            var result = await _classController.Select();
            if(result != null)
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
