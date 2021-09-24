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
    public class AstronautsController : ControllerBase
    {
        #region Fields

        private readonly IAstronautService _astronautService;

        #endregion Fields

        #region Constructors

        public AstronautsController(IAstronautService astronautService)
        {
            _astronautService = astronautService;
        }

        #endregion Constructors

        #region Methods

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var foundItem = await _astronautService.GetByIdAsync(id);
                await _astronautService.DeleteAsync(id);
                return Ok(foundItem);
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
                var astronauts = _astronautService.ListAllAsync();
                return await Task.FromResult(Ok(astronauts));
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(AstronautRequestDto astronautRequestDto)
        {
            var astronautResponseDto = await _astronautService.AddAsync(astronautRequestDto);
            return CreatedAtAction(nameof(Post), new { id = astronautResponseDto.Id }, astronautResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(AstronautRequestDto astronautRequestDto)
        {
            try
            {
                var astronautResponseDto = await _astronautService.UpdateAsync(astronautRequestDto);
                return Ok(astronautResponseDto);
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