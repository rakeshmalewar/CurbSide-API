using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Web.Http;
using DH.CurbSide.Repository;
using DH.CurbSide.Domain;
using System.Web;
using System.Collections.Specialized;

namespace DH.CurbSide.Submitter.Services.Controllers
{
    [ApiVersion("1.0")]
    public class WhitelistController : ApiController
    {
        [Route("api/v{version:apiVersion}/{tenantid}/GetWhitelist")] /*http://localhost:59976/api/v1.0/1/GetWhitelist?email=dh.org */
        [HttpGet]
        [MapToApiVersion("1.0")]
        public HttpResponseMessage GetWhitelist()
        {
            NameValueCollection nvc = HttpUtility.ParseQueryString(Request.RequestUri.Query);
            var searchEmail = nvc["email"];

            WhitelistRepo wlList = new WhitelistRepo();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(wlList.GetWhitelist(searchEmail));

            return new HttpResponseMessage()
            {
                Content = new StringContent(json.ToString(), System.Text.Encoding.UTF8, "application/json")
            };

        }
    }
}
