using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgvCco.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AgvCompra.WebServices 
{
    /// <summary>
    /// Controller
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ApiControllerBase
    {
        /// <summary>
        /// View Model
        /// </summary>
        readonly ViewModelCar viewModel;
        
        /// <summary>
        /// Consructor
        /// </summary>
        /// <param name="connectionContext"></param>
        public CarController(IOptions<ConnectionContext> connectionContext) : base(connectionContext)
        {
            viewModel = new ViewModelCar(ConnectionContext.GetProvider(), ConnectionContext.GetConnectionString());
        }

        // GET: api/Car
        [HttpGet("")]
        public IActionResult Get()
        {
            return null;
        }

        /// <summary>
        /// Obtener datos antes de grabar
        /// </summary>
        /// <param name="State"></param>
        /// <param name="Carusu"></param>
        /// <returns></returns>
        // GET: api/Car/5
        [HttpGet("{State}/{Carusu}")]
        public IActionResult Get(string State, Int32 Carusu)

        {
            return Ok(viewModel.GetCarSta(State, Carusu));
        }
        /// <summary>
        /// Adicionar al carrito
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        // POST: api/Car
        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            return Ok(viewModel.AddCar(car));
        }

        // PUT: api/Car/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return null;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return null;
        }
    }
}
