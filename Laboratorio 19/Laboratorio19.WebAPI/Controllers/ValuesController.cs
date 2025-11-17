using System.Collections.Generic;
using System.Web.Http;

namespace Laboratorio19.WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/2
        public string Get(int id)
        {
            if (id == 2) return "value2";
            return "value" + id;
        }
    }
}
