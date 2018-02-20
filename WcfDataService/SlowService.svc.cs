using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace WcfDataService
{
    public class SlowService : ISlowService
    {
        public string Delay(int delayMillis)
        {
            var startTime = DateTime.UtcNow;
            Thread.Sleep(delayMillis);
            var endTime = DateTime.UtcNow;
            return string.Format("Delay of {0}ms from {1:HH:mm:ss.fff} to {2:HH:mm:ss.ff}", delayMillis, startTime, endTime);
        }
    }
}
