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
    public class SpaceCraftsController : ControllerBase
    {
        #region Fields

        private readonly ISpaceCraftService _spaceCraftService;

        #endregion Fields

        #region Constructors

        public SpaceCraftsController(ISpaceCraftService spaceCraftService)
        {
            _spaceCraftService = spaceCraftService;
        }

        #endregion Constructors

        #region Methods

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            try
            {
                var spaceCrafts = await _spaceCraftService.ListAllAsync();
                return Ok(spaceCrafts);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpGet("isMannedCraft")]
        public async Task<IActionResult> Get(bool isMannedCraft)
        {
            try
            {
                return Ok(await _spaceCraftService.ListAllByMannedTypeAsync(isMannedCraft));
            }
            catch (System.Exception e)
            {
                Debug.WriteLine($"{e.Message} - {e.InnerException}");
                return BadRequest();
            }
        }

        [HttpGet("{spaceCraftId}/{isMannedCraft}")]
        public async Task<IActionResult> Get(Guid spaceCraftId, bool isMannedCraft)
        {
            try
            {
                var foundItem = await _spaceCraftService.GetByIdAsync(spaceCraftId, isMannedCraft);
                return Ok(foundItem);
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