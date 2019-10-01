using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Common.Models
{
    /// <summary>
    /// Carrito de compra
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Ide del ingreso
        /// </summary>
        public Int64          Caride { get; set; }
        /// <summary>
        /// Producto
        /// </summary>
        public Int64          Carpro { get; set; }
        /// <summary>
        /// Cantidad
        /// </summary>
        public decimal      Carcan { get; set; }
        /// <summary>
        /// Ususario de la compra
        /// </summary>
        public Int64?         Carusu { get; set; }
        /// <summary>
        /// Facha de la compra
        /// </summary>
        public DateTime?    Carfeh { get; set; }
        /// <summary>
        /// Estado
        /// </summary>
        public string       Carest { get; set; }
        /// <summary>
        /// Nombre producto
        /// </summary>
        public string       Pronom { get; set; }
    }
}
