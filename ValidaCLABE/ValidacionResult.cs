using System;
using System.Collections.Generic;
using System.Text;

namespace ValidaCLABE
{
    /// <summary>
    /// Resultado de la validación.
    /// </summary>
    public class ValidacionResult
    {
        public Banco Banco { get; set; }
        public String Sucursal { get; set; }
        public String NumeroCuenta { get; set; }
        public Boolean Valido { get; set; }
        public String ValidacionMensaje { get; set; }
    }
}
