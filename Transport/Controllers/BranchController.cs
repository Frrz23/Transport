using Microsoft.AspNetCore.Mvc;
using Transport.Models;
using Transport.Service.IService;

namespace Transport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _branchService.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var branch = await _branchService.GetByIdAsync(id);
            if (branch == null) return NotFound();
            return Ok(branch);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Branch branch) =>
            Ok(await _branchService.CreateAsync(branch));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Branch branch)
        {
            if (id != branch.BranchId) return BadRequest();
            return Ok(await _branchService.UpdateAsync(branch));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) =>
            Ok(await _branchService.DeleteAsync(id));
    }
}
