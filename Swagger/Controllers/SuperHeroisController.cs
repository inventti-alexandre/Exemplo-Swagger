using Swagger.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Swagger.Controllers
{
    [RoutePrefix("api/SuperHerois")]
    public class SuperHeroisController : ApiController
    {
        /// <summary>
        /// Método que obtem um super heroi....
        /// </summary>
        /// <param name="id">Id do super heroi</param>
        /// <returns></returns>
        /// <remarks>Obtem um super heroi pelo Id aluno</remarks>
        /// <response code="200">Ok</response>
        /// <response code="400">BadRequest</response>
        /// <response code="500">InternalServerError</response>
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest, "BadRequest")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError")]
        [ResponseType(typeof(Heroi))]
        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        [SwaggerResponse(HttpStatusCode.Created)]
        [SwaggerResponse(HttpStatusCode.BadRequest, "BadRequest")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError")]
        [ResponseType(typeof(Heroi))]
        [HttpPost]
        public IHttpActionResult Post([FromBody] HeroiInput input)
        {
            var obj = new Heroi();
            return Created(Request.RequestUri + "/" + obj.Id, obj);
        }

        [SwaggerResponse(HttpStatusCode.Accepted)]
        [SwaggerResponse(HttpStatusCode.NotFound, "NotFound")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError")]
        [ResponseType(typeof(Heroi))]
        [Route("{id}")]
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] HeroiInput input)
        {
            var obj = new Heroi();
            return Content(HttpStatusCode.Accepted, obj);
        }

        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound, "NotFound")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError")]
        [ResponseType(typeof(Heroi))]
        [Route("{id}")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        { 
           return Ok();
        }

    }
}
