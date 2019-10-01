using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AgvCompra.WebServices
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ApiControllerBase
    {
        /// <summary>
        /// Member productos
        /// </summary>
        readonly ViewModelProduct viewModel;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connectionContext"></param>
        public ProductController(IOptions<ConnectionContext> connectionContext) : base(connectionContext)
        {
            viewModel = new ViewModelProduct(ConnectionContext.GetProvider(), ConnectionContext.GetConnectionString());
        }

        /// <summary>
        /// Obtener todos los productos
        /// </summary>        
        /// <returns></returns>
        // GET: api/Product
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(viewModel.GetAllPro());
        }

        /// <summary>
        /// Obtener un producto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return null;
        }

        /// <summary>
        /// Insertar productos
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        // POST: api/Product
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return null;
        }

        /// <summary>
        /// Actualizar productos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        // PUT: api/Product/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return null;
        }

        /// <summary>
        /// Eliminar productos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return null;
        }
    }
}
