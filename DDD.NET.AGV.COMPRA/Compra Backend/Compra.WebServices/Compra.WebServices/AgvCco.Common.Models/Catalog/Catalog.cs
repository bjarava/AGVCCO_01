using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Common.Models
{
    /// <summary>
    /// Catálogo de unidades
    /// </summary>
    public class Catalog
    {
        /// <summary>
        /// ide
        /// </summary>
        public int Catide { get; set; }
        /// <summary>
        /// producto
        /// </summary>
        public int Catpro { get; set; }
        /// <summary>
        /// Cantidad
        /// </summary>
        public int Catcan { get; set; }
        /// <summary>
        /// referencia
        /// </summary>
        public string Catref { get; set; }
    }
}
