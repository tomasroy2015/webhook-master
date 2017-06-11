using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ebay.web.ebayService;
using APIManager.Core.Common;
using ebay.web.BL;

namespace ebay.web.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            FindItemsAdvancedRequest request = new FindItemsAdvancedRequest();
           // request.keywords = keyword.Text;
            if (request.keywords == null)
            {
                request.keywords = "ipod";
            }
            PaginationInput pi = new PaginationInput();
            pi.entriesPerPage = 10;
            pi.entriesPerPageSpecified = true;
            request.paginationInput = pi;

            // Call the service
            FindingServicePortTypeClient client;
            string appID = System.Configuration.ConfigurationManager.AppSettings["AppID"];
            string findingServerAddress = System.Configuration.ConfigurationManager.AppSettings["FindingServerAddress"];

            APIManager.Core.Configuration.ClientConfig config = new APIManager.Core.Configuration.ClientConfig();
            // Initialize service end-point configration
            config.EndPointAddress = findingServerAddress;

            // set eBay developer account AppID
            config.ApplicationId = appID;

            // Create a service client
            client = FindingServiceClientFactory.getServiceClient(config);
            FindItemsAdvancedResponse response = client.findItemsAdvanced(request);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
