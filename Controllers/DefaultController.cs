using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using test1.Data;
using MySql.Data.MySqlClient;

namespace test1.Controllers
{
    public class DefaultController : ApiController
    {
        [AcceptVerbs("GET")]
        [Route("test/{id}")]
        public async Task<IHttpActionResult> test (string id)
        {
            //DatabaseConnect.connectToDB();
            return Ok(new { date = DateTime.Now, data = id });
        }
    }
}
