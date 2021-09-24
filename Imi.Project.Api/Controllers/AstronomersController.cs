using Imi.Project.Api.Core.Dtos.RequestDtos.Scientists;
using Imi.Project.Api.Core.Interfaces.Services.Scientists;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class AstronomersController : Controller
    {
        #region Fields

        private readonly IAstronomerService _astronomerService;

        #endregion Fields

        #region Methods

        public AstronomersController(IAstronomerService astronomerService)
        {
            _astronomerService = astronomerService;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var itemToDelete = await _astronomerService.GetByIdAsync(id);
                await _astronomerService.DeleteAsync(id);
                return Ok(itemToDelete);
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            try
            {
                var astronomers = await _astronomerService.ListAllAsync();
                return Ok(astronomers);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(AstronomerRequestDto astronomerRequestDto)
        {
            try
            {
                var response = await _astronomerService.AddAsync(astronomerRequestDto);
                return CreatedAtAction(nameof(Post), response);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(AstronomerRequestDto astronomerRequestDto)
        {
            try
            {
                var astronomerResponseDto = await _astronomerService.UpdateAsync(astronomerRequestDto);
                return Ok(astronomerResponseDto);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        #endregion Methods
    }
}