using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FishfoodService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Fishfood" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Fishfood.svc or Fishfood.svc.cs at the Solution Explorer and start debugging.
    public class Fishfood : IFishfood
    {
        public ResponseData Send(RequestData qData)
        {
            var data = qData.searchinfo.Split(':');
            var reponse = new ResponseData
            {
                url = data[0],
                term = data[1],
                date = data[2],
                offset = data[3]
            };
            return reponse;
        }
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
