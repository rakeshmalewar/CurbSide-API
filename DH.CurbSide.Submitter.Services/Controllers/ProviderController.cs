using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Web.Http;
using DH.CurbSide.Repository;
using DH.CurbSide.Domain;


namespace DH.CurbSide.Submitter.Services.Controllers
{
    [ApiVersion("1.0")]
    public class ProviderController : ApiController
    {
        //private DataContext db = new DataContext();
        /*
        public IQueryable<Provider> GetProvidersList()rovi
        {
            var prvdQuery = from prvd in db.ProvidersList
                           select prvd;
            IQueryable<Provider> prvdList = prvdQuery;
            return db.ProvidersList.AsQueryable();
        }
        */

        [Route("api/v{version:apiVersion}/GetProvidersList")] /*http://localhost:59976/api/v1.0/GetProvidersList */
        [HttpGet]
        [MapToApiVersion("1.0")]
        public HttpResponseMessage GetProvidersList()
        {

            /*
            List<Provider> prvdList = new List<Provider>();
            using (DataContext db = new DataContext())
            {
                var prvdQuery = from prvd in db.ProvidersList
                                select prvd;
                prvdList = prvdQuery.ToList();
            }
            */
            ProviderRepo prvList = new ProviderRepo();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(prvList.GetProviders());
            return new HttpResponseMessage()
            {
                Content = new StringContent(json.ToString(), System.Text.Encoding.UTF8, "application/json")
            };

        }
        //private DataContext db = new DataContext();
        [Route("AddProvider")]
        [HttpPost]

        public HttpResponseMessage Post(Provider providerDetail)
        {
            /*
            if (!ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            db.ProvidersList.Add(providerDetail);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
            }
            */
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

    }
}
