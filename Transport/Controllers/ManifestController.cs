using Microsoft.AspNetCore.Mvc;
using Transport.Dto;
using Transport.Service;

namespace Transport.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManifestController : ControllerBase
    {
        private readonly ManifestService _service;

        public ManifestController(ManifestService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateManifestDto dto)
        {
            try
            {
                var manifest = await _service.CreateManifestAsync(dto);
                return Ok(manifest);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var manifests = await _service.GetAllAsync();
            return Ok(manifests);
        }
    }
}
