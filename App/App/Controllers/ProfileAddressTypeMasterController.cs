using App.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileAddressTypeMasterController: ControllerBase
    {
        private readonly IProfileAddressTypeMaster _repo;

        public ProfileAddressTypeMasterController(IProfileAddressTypeMaster repo)
        {
            _repo = repo;
        }

        [HttpGet("GetList/{clientserno}")]
        public IActionResult GetList(int clientserno)
        {
            return Ok(_repo.GetList(clientserno));
        }
    }
}
