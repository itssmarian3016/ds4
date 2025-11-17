using System.Web.Http;
using Laboratorio19.WebAPI.Models.WS;

namespace Laboratorio19.WebAPI.Controllers
{
    public class AccessController : ApiController
    {
        [HttpGet]
        [Route(" + '"' + "api/access/helloworld" + '"' + ")]
        public Reply HelloWorld()
        {
            return new Reply { Result = 200, Data = null, Message = "Hello World desde API" };
        }
    }
}
