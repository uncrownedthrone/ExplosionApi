using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MumblingController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetMumbling()
    {
      var kataQuestion = new List<string>() { };
      return Ok(new { });
    }
  }
}