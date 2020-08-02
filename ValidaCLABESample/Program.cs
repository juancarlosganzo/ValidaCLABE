using System;
using ValidaCLABE;

namespace ValidaCLABESample
{
    class Program
    {
        static void Main(string[] args)
        {
            string CLABETest = "127050002860553945";
            ValidacionResult result = ValidarCLABE.Validar(CLABETest);

            Console.WriteLine("===========================================================");
            Console.WriteLine("CLABE Valida:" + result.Valido);
            Console.WriteLine("CLABE Mensaje Error:" + result.ValidacionMensaje);
            Console.WriteLine("Número Cuenta:" + result.NumeroCuenta);
            Console.WriteLine("Banco:" + result.Banco.Clave);
            Console.WriteLine(result.Banco.NombreAbreviado);
            Console.WriteLine(result.Banco.Institucion);
            Console.WriteLine("Sucrusal: " + result.Sucursal);
            Console.WriteLine("===========================================================");

            Console.WriteLine("");
            Console.WriteLine("========================Listado de Bancos===================");
            foreach (Banco banco in Banco.Listado()) {
                Console.WriteLine($"Clave:{banco.Clave} Nombre:{banco.NombreAbreviado} Institución:{banco.Institucion}");
            }
            Console.WriteLine("===========================================================");





        }
    }
}
