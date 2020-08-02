using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidaCLABE
{
    public class ValidarCLABE
    {
        private static int[] factorPeso = { 3, 7, 1, 3, 7, 1, 3, 7, 1, 3, 7, 1, 3, 7, 1, 3, 7, 1 };
        public static ValidacionResult Validar(string CLABE)
        {

            ValidacionResult validacionResult = new ValidacionResult() ;

            if (string.IsNullOrEmpty(CLABE))
            {
                validacionResult.Valido = false;
                validacionResult.ValidacionMensaje = "Valor en blanco";
            }
            if (CLABE.Length != 18)
            {
                validacionResult.Valido = false;
                validacionResult.ValidacionMensaje = "El tamaño de la CLABE debe ser de 18 digitos";
            }

            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(CLABE))
            {
                validacionResult.Valido = false;
                validacionResult.ValidacionMensaje = "La CLABE solo admite digitos.";
            }

            string claveBanco = CLABE.Substring(0, 3);

            validacionResult.Banco = Banco.Listado().FirstOrDefault(b => b.Clave.Equals(claveBanco));
            validacionResult.Sucursal = CLABE.Substring(3, 3);
            validacionResult.NumeroCuenta = CLABE.Substring(6, 11);

            int sumaFactores = 0;
            for (int indexCLABE = 0; indexCLABE < 17; indexCLABE++)
            {
                var producto = (Convert.ToInt32(CLABE.Substring(indexCLABE, 1)) * factorPeso[indexCLABE]) % 10;
                sumaFactores = sumaFactores + producto;
            }

            string digitoVerificador = (10 - (sumaFactores % 10)).ToString();            

            if (!CLABE.Substring(17, 1).Equals(digitoVerificador))
            {
                validacionResult.Valido = false;
                validacionResult.ValidacionMensaje = "Digito verificador invalido.";

            }
            else {
                validacionResult.Valido = true;
            }


            return validacionResult;
        }
    }
}
