using System;
using Xunit;
using Microsoft.Extensions.Options;
using AgvCompra.WebServices;
using AgvCco.Common.Models;

namespace AgvCco.UniTest
{
    /// <summary>
    /// Unitext para consulta de todos los productos disponibles en catalogo
    /// </summary>
    public class CarUnitTest
    {
        /// <summary>
        /// Unitext para adicionar al carrito
        /// </summary>
        [Fact]
        public void AddCar()
        {
            CarController carController = new CarController(new CarDBParameters());
            var result = carController.Post(new Car {Carcan = 1, Carest ="ADD", Carfeh = DateTime.Now, Carpro = 1, Carusu = null });            
        }
    }
    /// <summary>
    /// Context DB connection para Unitext de los métodos a probar
    /// </summary>
    public class CarDBParameters : IOptions<ConnectionContext>
    {
        public ConnectionContext Value => new ConnectionContext()
        {
            ConnectionString = "Data Source=Benja-PC; Initial Catalog=AGVCCO; persist Security Info=True; User ID=sa; Password=giro2070.",
            Provider = "SqlServer"
        };
    } 
     
}
