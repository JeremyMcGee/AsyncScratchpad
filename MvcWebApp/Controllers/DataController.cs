using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWebApp.Controllers
{
    public class DataController : ApiController
    {
        // GET: api/Data
        public string Get(int delay)
        {
            var slowService = new SlowService.SlowServiceClient();
            return slowService.Delay(delay);
        }
    }
}
