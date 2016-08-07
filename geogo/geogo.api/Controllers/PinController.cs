namespace geogo.api.Controllers
{
    using geogo.domain.database;
    using geogo.service.Interface;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;

    [RoutePrefix("pins")]
    public class PinController : ApiController
    {
        private readonly IDBAccessService _svc;

        public PinController(IDBAccessService svc)
        {
            _svc = svc;
        }

        [Route(""), HttpGet]
        public async Task<IHttpActionResult> GetAllPins() {
            IList<tbPin> list = new List<tbPin>();

            try {
                list = await _svc.GetAllPins();
            }
            catch (Exception ex)
            { }

            return Ok(list);
        }
    }
}
