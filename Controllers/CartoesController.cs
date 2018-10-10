using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_typed_httpclient.HttpClients;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace dotnet_typed_httpclient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartoesController : ControllerBase
    {
        private readonly CartoesHttpClient cartoesClient;

        public CartoesController(CartoesHttpClient cartoesClient)
        {
            this.cartoesClient = cartoesClient;
        }

        [HttpGet]
        public async Task<ActionResult<JToken>> Get()
        {
            return await cartoesClient.GetCartoes();
        }
    }
}
