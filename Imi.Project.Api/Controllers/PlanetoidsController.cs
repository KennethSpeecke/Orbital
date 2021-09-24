using Imi.Project.Api.Core.Dtos.RequestDtos.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Services.SpaceObjects;
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
    public class PlanetoidsController : ControllerBase
    {
        #region Fields

        private readonly IPlanetoidService _planetoidService;

        #endregion Fields

        #region Constructors

        public PlanetoidsController(IPlanetoidService planetoidService)
        {
            _planetoidService = planetoidService;
        }

        #endregion Constructors

        #region Methods

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var planetoids = await _planetoidService.ListAllAsync();
            return Ok(planetoids);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var foundItem = await _planetoidService.GetByIdAsync(id);
                return Ok(foundItem);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(PlanetoidRequestDto planetoidRequestDto)
        {
            try
            {
                var planetoidResponseDto = await _planetoidService.AddAsync(planetoidRequestDto);
                return CreatedAtAction(nameof(Post), new { id = planetoidResponseDto.Id }, planetoidResponseDto);
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