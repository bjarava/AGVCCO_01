using System;
using System.Collections.Generic;
using System.Text;

namespace AgvCco.Common.Models
{
    /// <summary>
    /// Usuario
    /// </summary>
    public class User
    {
        /// <summary>
        /// identificador de usuario
        /// </summary>
        public int usuide { get; set; }
        /// <summary>
        /// Documento
        /// </summary>
        public string usudoc { get; set; }
        /// <summary>
        /// Nombre
        /// </summary>
        public string usunom { get; set; }
        /// <summary>
        /// apellido
        /// </summary>
        public string usuape { get; set; }
        /// <summary>
        /// Telefono
        /// </summary>
        public string usutel { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string usuema { get; set; }
        /// <summary>
        /// Fecha de registro
        /// </summary>
        public DateTime usufcr { get; set; }
    }
}
