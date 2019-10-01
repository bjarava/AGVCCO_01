using System;
using Xunit;
using Microsoft.Extensions.Options;
using AgvCompra.WebServices;

namespace AgvCco.UniTest
{
    /// <summary>
    /// Unitext para consulta de todos los productos disponibles en catalogo
    /// </summary>
    public class ProductUnitTest
    {
        /// <summary>
        /// Unitext para consulta de todos los productos disponibles en catalogo
        /// </summary>
        [Fact]
        public void GetAllPro()
        {
            ProductController productController = new ProductController(new ProductDBParameters());
            var result = productController.Get();            
        }
    }
    /// <summary>
    /// Context DB connection para Unitext de los métodos a probar
    /// </summary>
    public class ProductDBParameters : IOptions<ConnectionContext>
    {
        public ConnectionContext Value => new ConnectionContext()
        {
            ConnectionString = "Data Source=Benja-PC; Initial Catalog=AGVCCO; persist Security Info=True; User ID=sa; Password=giro2070.",
            Provider = "SqlServer"
        };
    } 
     
}
