﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FishfoodService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFishfood" in both code and config file together.
    [ServiceContract]
    public interface IFishfood
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "send")]
        ResponseData Send(RequestData qData);
    }
}