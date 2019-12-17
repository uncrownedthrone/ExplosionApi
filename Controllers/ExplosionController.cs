using System;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ExplosionController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetExplosion()
    {
      return Ok(new { Explosion = DateTime.Now });
    }
  }
}