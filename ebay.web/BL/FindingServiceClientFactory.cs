using APIManager.Core.Common;
using ebay.web.ebayService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ebay.web.BL
{
    public static class FindingServiceClientFactory
    {
        /// <summary>
        /// A simple interface to get eBay Finding Service client proxy
        /// </summary>
        /// <param name="config">Client configuration</param>
        /// <returns>eBay Finding Service client proxy of type FindingServicePortTypeClient</returns>
        /// 

        public static FindingServicePortTypeClient getServiceClient(APIManager.Core.Configuration.ClientConfig config)
        {
            return (FindingServicePortTypeClient)ClientFactory.GetSerivceClient<FindingServicePortType>(config, typeof(FindingServicePortTypeClient), ServiceConstants.FINDING_SERVICE_NAME);
        }
    }
}