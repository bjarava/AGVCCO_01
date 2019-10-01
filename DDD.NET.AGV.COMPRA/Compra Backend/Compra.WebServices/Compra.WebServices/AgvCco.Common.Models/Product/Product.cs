using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Common.Models 
{
    /// <summary>
    /// Entidad producto
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Id del producto
        /// </summary>
        public Int64 Proide { get; set; }
        /// <summary>
        /// Nombre
        /// </summary>
        public string Pronom { get; set; }
        /// <summary>
        /// Precio
        /// </summary>
        public decimal Propre { get; set; }
        /// <summary>
        /// Fecha de creacion del producto
        /// </summary>
        public DateTime Profcr { get; set; }
        /// <summary>
        /// Cantidad existente en catálogo
        /// </summary>
        public int Procan { get; set; }
        /// <summary>
        /// Referencia del catálogo
        /// </summary>
        public string Proref { get; set; }

    }
}
