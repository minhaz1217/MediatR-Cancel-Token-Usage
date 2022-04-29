using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Requester;

namespace MediatR_Cancel_Token_Usage.Controllers
{
    [Route("/api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly RequesterService _requesterService;
        public HomeController(RequesterService requesterService)
        {
            _requesterService = requesterService;
        }

        [HttpGet("get-value")]
        public async Task<IActionResult> GetValueAsync(string key)
        {
            try
            {
                var value = await _requesterService.GetValueAsync(key);
                return Ok(value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
