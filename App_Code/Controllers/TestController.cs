using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[RoutePrefix("api")]
public class TestController : ApiController
{
    [HttpGet]
    [Route("test")]
    public IHttpActionResult Test()
    {
        return Ok(new
        {
            all = "Good!"
        });
    }
}