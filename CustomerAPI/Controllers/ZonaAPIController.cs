using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Net.Http;
using System.Web.Routing;
using DentisoftRepository;
using DentisoftEntities.Entities;

namespace DentisoftAPI.Controllers
{
    //[Authorize]
    public class ZonaAPIController : ApiController
    {
       
        public ZonaAPIController()
        {
        }
        [AllowAnonymous]
        public Zona[] Get()
        {
            var RepZona = new ZonaRepositorio();
            return RepZona.GetALL();
        }

        [HttpPost]
        public HttpResponseMessage Post(Zona _zona)
        {
            var RepZona = new ZonaRepositorio();
            if (_zona.Id == 0)
            {
                RepZona.Insert(_zona);
            }
            else
            {
                RepZona.Update( _zona.Id,_zona);
            }
           HttpResponseMessage response = Request.CreateResponse<Zona>(System.Net.HttpStatusCode.Created, _zona);
            return response;
        }

        // DELETE api/values/5
        [HttpDelete]
        public virtual HttpResponseMessage Delete(int id)
        {
            var RepZona = new ZonaRepositorio();
            if (id != 0)
            {
                RepZona.Delete(id);
            }
            HttpResponseMessage response = Request.CreateResponse<int>(System.Net.HttpStatusCode.Created, id);
            return response;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {

        }

    }
}
