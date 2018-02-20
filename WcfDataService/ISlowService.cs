using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDataService
{
    [ServiceContract]
    public interface ISlowService
    {

        [OperationContract]
        string Delay(int value);
    }
}
