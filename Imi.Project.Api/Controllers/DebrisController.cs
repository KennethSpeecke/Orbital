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
    [Authorize(Roles = "admin")]
    [ApiController]
    public class DebrisController : ControllerBase
    {
        #region Fields

        private readonly IDebrisService _debrisService;

        #endregion Fields

        #region Constructors

        public DebrisController(IDebrisService debrisService)
        {
            _debrisService = debrisService;
        }

        #endregion Constructors

        #region Methods

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var itemToDelete = await _debrisService.GetByIdAsync(id);
                await _debrisService.DeleteAsync(id);
                return Ok(itemToDelete);
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var debrisCollection = await _debrisService.ListAllAsync();
                return Ok(debrisCollection);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var foundItem = await _debrisService.GetByIdAsync(id);
                return Ok(foundItem);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(DebrisRequestDto debrisRequestDto)
        {
            try
            {
                var response = await _debrisService.AddAsync(debrisRequestDto);
                return CreatedAtAction(nameof(Post), response);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(DebrisRequestDto debrisRequestDto)
        {
            try
            {
                var response = await _debrisService.UpdateAsync(debrisRequestDto);
                return CreatedAtAction(nameof(Put), response);
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