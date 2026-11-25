using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace learn_cicd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static readonly List<string> Items = new() { "a", "b" };
        [HttpGet("char")]
        public IActionResult getResutl()
        {
            return Ok(Items);
        }

        [HttpPost]
        public IActionResult post(List<string> list)
        {
            list.Add("cd");
            return Ok(list);
        }
    }

}
