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
    [Authorize(Roles = "admin")]
    [ApiController]
    public class NotableWorksController : ControllerBase
    {
        #region Fields

        private readonly INotableWorkService _notableWorkService;

        #endregion Fields

        #region Constructors

        public NotableWorksController(INotableWorkService notableWorkService)
        {
            _notableWorkService = notableWorkService;
        }

        #endregion Constructors

        #region Methods

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var itemToDelete = await _notableWorkService.GetByIdAsync(id);
                await _notableWorkService.DeleteAsync(id);
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
                var notableWorks = await _notableWorkService.ListAllAsync();
                return Ok(notableWorks);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpPost("{astronomerId}")]
        public async Task<IActionResult> Post(NotableWorkRequestDto notableWorkRequestDto, Guid astronomerId)
        {
            try
            {
                var response = await _notableWorkService.AddAsync(notableWorkRequestDto, astronomerId);
                return CreatedAtAction(nameof(Post), response);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpPut("{astronomerId}")]
        public async Task<IActionResult> Put(NotableWorkRequestDto notableWorkRequestDto, Guid astronomerId)
        {
            try
            {
                var response = await _notableWorkService.UpdateAsync(notableWorkRequestDto, astronomerId);
                return CreatedAtAction(nameof(Put), response);
            }
            catch (Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        #endregion Methods
    }
}