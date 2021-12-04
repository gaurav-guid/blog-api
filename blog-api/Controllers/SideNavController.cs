using blog_business.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SideNavController : ControllerBase
    {
        private readonly ISideNavFacade _sideNavFacade;
        private readonly ILogger<SideNavController> _logger;

        public SideNavController(ISideNavFacade sideNavFacade, ILogger<SideNavController> logger)
        {
            this._sideNavFacade = sideNavFacade;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllLinksByCategoryId(Guid categoryId)
        {
            try
            {
                return Ok(_sideNavFacade.GetAllLinksByCategoryId(categoryId));
            }
            catch
            {
                return StatusCode(500, "Some error occured. Please contact admin.");
            }
        }
    }
}
