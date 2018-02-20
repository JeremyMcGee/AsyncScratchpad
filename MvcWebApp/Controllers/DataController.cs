using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MvcWebApp.Controllers
{
    public class DataController : ApiController
    {
        [Route("api/Data")]
        [HttpGet]
        public string Get(int delay)
        {
            using (var slowService = new SlowService.SlowServiceClient())
            {
                return slowService.Delay(delay);
            }
        }

        [Route("api/DataAsync")]
        [HttpGet]
        public async Task<string> GetWithTask(int delay)
        {
            using (var slowService = new SlowService.SlowServiceClient())
            {
                return await slowService.DelayAsync(delay);
            }
        }
    }
}
