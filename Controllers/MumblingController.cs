using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExplosionApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MumblingController : ControllerBase
  {
    [HttpGet("letter")]
    public ActionResult<string> GetMumblin(string s)
    {
      return string.Join("-", s.Select((n, i) => char.ToUpper(n) + new string(char.ToLower(n), i)));
    }
  }
}