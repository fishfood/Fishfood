using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ifishfood" in both code and config file together.
    [ServiceContract]
    public interface Ifishfood
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "send")]
        ResponseData Send(RequestData qData);
    }

    [DataContract]
    public class RequestData
    {
        [DataMember]
        public string searchinfo { get; set; }
    }

    [DataContract]
    public class ResponseData
    {
        [DataMember]
        public string url { get; set; }

        [DataMember]
        public string term { get; set; }

        [DataMember]
        public string date { get; set; }

        [DataMember]
        public string offset { get; set; }
    }
}
