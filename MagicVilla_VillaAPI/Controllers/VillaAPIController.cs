using MagicVilla_VillaAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> getVillas()
        {
            return new List<Villa>
            {
                new Villa { Id=1,Name="Pool View" },
                new Villa { Id=2,Name="Beach View"}
            };
        }
    }
}
