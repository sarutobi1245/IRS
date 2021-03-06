using System;
using System.Security.Claims;
using System.Threading.Tasks;
using INK_API.Helpers;
using INK_API._Services.Interface;
using INK_API.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace INK_API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SettingController : ControllerBase
    {
        private readonly ISettingService _settingService;
        public SettingController( ISettingService settingService)
        {
            _settingService = settingService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllSetting()
        {
            var settings = await _settingService.GetAllAsync();
            return Ok(settings);
        }

       
        // [HttpPost]
        // public async Task<IActionResult> Create(StirDTO create)
        // {

        //     //create.CreatedDate = DateTime.Now;
        //     if (await _settingService.Add(create))
        //     {
        //         return NoContent();
        //     }

        //     throw new Exception("Creating the Stir failed on save");
        // }

        // [HttpPut]
        // public async Task<IActionResult> Update(KindDto update)
        // {
        //     // if (await _kindService.Update(update))
        //     //     return NoContent();
        //     return BadRequest($"Updating Kind {update.ID} failed on save");
        // }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            // if (await _kindService.Delete(id))
            //     return NoContent();
            throw new Exception("Error deleting the Kind");
        }
    }
}