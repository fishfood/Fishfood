using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "fishfood" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select fishfood.svc or fishfood.svc.cs at the Solution Explorer and start debugging.
    public class fishfood : Ifishfood
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
}
