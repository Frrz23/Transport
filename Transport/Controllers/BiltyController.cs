using Microsoft.AspNetCore.Mvc;
using Transport.Dto;
using Transport.Service.IService;

namespace Transport.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BiltyController : ControllerBase
    {
        private readonly IBiltyService _biltyService;

        public BiltyController(IBiltyService biltyService)
        {
            _biltyService = biltyService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBiltyDto dto)
        {
            var id = await _biltyService.CreateBiltyAsync(dto);
            return Ok(new { BiltyId = id });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var bilty = await _biltyService.GetBiltyAsync(id);
            if (bilty == null) return NotFound();
            return Ok(bilty);
        }
    }

}
