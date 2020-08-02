using System;
using System.Collections.Generic;
using System.Text;

namespace ValidaCLABE
{
    /// <summary>
    /// Datos de la institución bancaria.
    /// </summary>
    public class Banco
    {
        private  static List<Banco> bancos = new List<Banco>() {
                new Banco(){ Clave= "002", Institucion = "Banco Nacional de México, S.A.", NombreAbreviado= "BANAMEX" },
                new Banco(){ Clave= "006", Institucion = "Banco Nacional de Comercio Exterior", NombreAbreviado= "BANCOMEXT" },
                new Banco(){ Clave= "009", Institucion = "Banco Nacional de Obras y Servicios Públicos", NombreAbreviado= "BANOBRAS" },
                new Banco(){ Clave= "012", Institucion = "BBVA Bancomer, S.A.", NombreAbreviado= "BBVA BANCOMER" },
                new Banco(){ Clave= "014", Institucion = "Banco Santander, S.A.", NombreAbreviado= "SANTANDER" },
                new Banco(){ Clave= "019", Institucion = "Banco Nacional del Ejército, Fuerza Aérea y Armada", NombreAbreviado= "BANJERCITO" },
                new Banco(){ Clave= "021", Institucion = "HSBC México, S.A.", NombreAbreviado= "HSBC" },
                new Banco(){ Clave= "022", Institucion = "GE Money Bank, S.A.", NombreAbreviado= "GE MONEY" },
                new Banco(){ Clave= "030", Institucion = "Banco del Bajío, S.A.", NombreAbreviado= "BAJÍO" },
                new Banco(){ Clave= "032", Institucion = "IXE Banco, S.A.", NombreAbreviado= "IXE" },
                new Banco(){ Clave= "036", Institucion = "Banco Inbursa, S.A.", NombreAbreviado= "INBURSA" },
                new Banco(){ Clave= "037", Institucion = "Banco Interacciones, S.A.", NombreAbreviado= "INTERACCIONES" },
                new Banco(){ Clave= "042", Institucion = "Banca Mifel, S.A.", NombreAbreviado= "MIFEL" },
                new Banco(){ Clave= "044", Institucion = "Scotiabank Inverlat, S.A.", NombreAbreviado= "SCOTIABANK" },
                new Banco(){ Clave= "058", Institucion = "Banco Regional de Monterrey, S.A.", NombreAbreviado= "BANREGIO" },
                new Banco(){ Clave= "059", Institucion = "Banco Invex, S.A.", NombreAbreviado= "INVEX" },
                new Banco(){ Clave= "060", Institucion = "Bansi, S.A.", NombreAbreviado= "BANSI" },
                new Banco(){ Clave= "062", Institucion = "Banca Afirme, S.A.", NombreAbreviado= "AFRIME" },
                new Banco(){ Clave= "072", Institucion = "Banco Mercantil del Norte, S.A.", NombreAbreviado= "BANORTE" },
                new Banco(){ Clave= "102", Institucion = "The Royal Bank of Scotland México, S.A.", NombreAbreviado= "THE ROYAL BANK" },
                new Banco(){ Clave= "103", Institucion = "American Express Bank (México), S.A.", NombreAbreviado= "AMERICAN EXPRESS" },
                new Banco(){ Clave= "106", Institucion = "Bank of America México, S.A.", NombreAbreviado= "BAMSA" },
                new Banco(){ Clave= "108", Institucion = "Bank of Tokyo-Mitsubishi UFJ (México), S.A.", NombreAbreviado= "TOKYO" },
                new Banco(){ Clave= "108", Institucion = "Banco J.P. Morgan, S.A.", NombreAbreviado= "JP MORGAN" },
                new Banco(){ Clave= "112", Institucion = "Banco Monex, S.A.", NombreAbreviado= "BMONEX" },
                new Banco(){ Clave= "113", Institucion = "Banco Ve por Mas, S.A.", NombreAbreviado= "VE POR MAS" },
                new Banco(){ Clave= "116", Institucion = "ING Bank (México), S.A.", NombreAbreviado= "ING" },
                new Banco(){ Clave= "124", Institucion = "Deutsche Bank México, S.A.", NombreAbreviado= "DEUTSCHE" },
                new Banco(){ Clave= "126", Institucion = "Banco Credit Suisse (México), S.A.", NombreAbreviado= "CREDIT SUISSE" },
                new Banco(){ Clave= "127", Institucion = "Banco Azteca, S.A.", NombreAbreviado= "AZTECA" },
                new Banco(){ Clave= "128", Institucion = "Banco Autofin México, S.A.", NombreAbreviado= "AUTOFIN" },
                new Banco(){ Clave= "129", Institucion = "Barclays Bank México, S.A.", NombreAbreviado= "BARCLAYS" },
                new Banco(){ Clave= "130", Institucion = "Banco Compartamos, S.A.", NombreAbreviado= "COMPARTAMOS" },
                new Banco(){ Clave= "131", Institucion = "Banco Ahorro Famsa, S.A.", NombreAbreviado= "FAMSA" },
                new Banco(){ Clave= "132", Institucion = "Banco Multiva, S.A.", NombreAbreviado= "BMULTIVA" },
                new Banco(){ Clave= "133", Institucion = "Banco Actinver, S.A.", NombreAbreviado= "ACTINVER" },
                new Banco(){ Clave= "134", Institucion = "Banco Wal Mart de México Adelante, S.A.", NombreAbreviado= "WAL-MART" },
                new Banco(){ Clave= "135", Institucion = "Nacional Financiera, S.N.C.", NombreAbreviado= "NAFIN" },
                new Banco(){ Clave= "136", Institucion = "Inter Banco, S.A.", NombreAbreviado= "INTERBANCO" },
                new Banco(){ Clave= "137", Institucion = "BanCoppel, S.A.", NombreAbreviado= "BANCOPPEL" },
                new Banco(){ Clave= "138", Institucion = "ABC Capital, S.A. I.B.M.", NombreAbreviado= "ABC CAPITAL" },
                new Banco(){ Clave= "139", Institucion = "UBS Banco, S.A.", NombreAbreviado= "UBS BANK" },
                new Banco(){ Clave= "140", Institucion = "Consubanco, S.A.", NombreAbreviado= "CONSUBANCO" },
                new Banco(){ Clave= "141", Institucion = "Volkswagen Bank S.A. Institución de Banca Múltiple", NombreAbreviado= "VOLKSWAGEN" },
                new Banco(){ Clave= "143", Institucion = "Consultoría Internacional Banco, S.A.", NombreAbreviado= "CIBanco" },
                new Banco(){ Clave= "145", Institucion = "Banco BASE, S.A. de I.B.M.", NombreAbreviado= "BBASE" },
                new Banco(){ Clave= "147", Institucion = "Bankaool, S.A., Institución de Banca Múltiple", NombreAbreviado= "BANKAOOL" },
                new Banco(){ Clave= "148", Institucion = "Banco PagaTodo S.A., Institución de Banca Múltiple", NombreAbreviado= "PagaTodo" },
                new Banco(){ Clave= "150", Institucion = "Banco Inmobiliario Mexicano, S.A., Institución de Banca Múltiple", NombreAbreviado= "BIM" },
                new Banco(){ Clave= "155", Institucion = "Industrial and Commercial Bank of China, S.A., Institución de Banca Múltiple", NombreAbreviado= "ICBC" },
                new Banco(){ Clave= "156", Institucion = "Banco Sabadell, S.A. I.B.M.", NombreAbreviado= "SABADELL" },
                new Banco(){ Clave= "166", Institucion = "Banco del Ahorro Nacional y Servicios Financieros, S.N.C.", NombreAbreviado= "BANSEFI" },
                new Banco(){ Clave= "168", Institucion = "Banco del Ahorro Nacional y Servicios Financieros, S.N.C.", NombreAbreviado= "HIPOTECARIA FEDERAL" },
                new Banco(){ Clave= "600", Institucion = "Monex Casa de Bolsa, S.A. de C.V.", NombreAbreviado= "MONEXCB" },
                new Banco(){ Clave= "601", Institucion = "GBM Grupo Bursátil Mexicano, S.A. de C.V.", NombreAbreviado= "GBM" },
                new Banco(){ Clave= "602", Institucion = "Masari Casa de Bolsa, S.A.", NombreAbreviado= "MASARI CB" },
                new Banco(){ Clave= "604", Institucion = "Inversora Bursátil, S.A. de C.V.", NombreAbreviado= "C.B. INBURSA" },
                new Banco(){ Clave= "605", Institucion = "Valué, S.A. de C.V., Casa de Bolsa", NombreAbreviado= "VALUÉ" },
                new Banco(){ Clave= "606", Institucion = "Estructuradores del Mercado de Valores Casa de Bolsa, S.A. de C.V.", NombreAbreviado= "ESTRUCTURADORES" },
                new Banco(){ Clave= "607", Institucion = "Casa de Cambio Tiber, S.A. de C.V.", NombreAbreviado= "TIBER" },
                new Banco(){ Clave= "608", Institucion = "Vector Casa de Bolsa, S.A. de C.V.", NombreAbreviado= "VECTOR" },
                new Banco(){ Clave= "610", Institucion = "B y B Casa de Cambio, S.A. de C.V.", NombreAbreviado= "B&B" },
                new Banco(){ Clave= "611", Institucion = "Intercam Casa de Cambio, S.A. de C.V.", NombreAbreviado= "INTERCAM" },
                new Banco(){ Clave= "613", Institucion = "Multivalores Casa de Bolsa, S.A. de C.V. Multiva Gpo. Fin.", NombreAbreviado= "MULTIVA" },
                new Banco(){ Clave= "614", Institucion = "Acciones y Valores Banamex, S.A. de C.V., Casa de Bolsa", NombreAbreviado= "ACCIVAL" },
                new Banco(){ Clave= "615", Institucion = "Merrill Lynch México, S.A. de C.V., Casa de Bolsa", NombreAbreviado= "MERRILL LYNCH" },
                new Banco(){ Clave= "616", Institucion = "Casa de Bolsa Finamex, S.A. de C.V.", NombreAbreviado= "FINAMEX" },
                new Banco(){ Clave= "617", Institucion = "Valores Mexicanos Casa de Bolsa, S.A. de C.V.", NombreAbreviado= "VALMEX" },
                new Banco(){ Clave= "618", Institucion = "Única Casa de Cambio, S.A. de C.V.", NombreAbreviado= "ÚNICA" },
                new Banco(){ Clave= "619", Institucion = "MAPFRE Tepeyac S.A.", NombreAbreviado= "MAPFRE" },
                new Banco(){ Clave= "620", Institucion = "Profuturo G.N.P., S.A. de C.V.", NombreAbreviado= "PROFUTURO" },
                new Banco(){ Clave= "621", Institucion = "Actinver Casa de Bolsa, S.A. de C.V.", NombreAbreviado= "CB ACTINBER" },
                new Banco(){ Clave= "622", Institucion = "OPERADORA ACTINVER, S.A. DE C.V.", NombreAbreviado= "OACTIN" },
                new Banco(){ Clave= "623", Institucion = "Skandia Vida S.A. de C.V.", NombreAbreviado= "SKANDIA" },
                new Banco(){ Clave= "624", Institucion = "Consultoría Internacional Casa de Cambio, S.A. de C.V.", NombreAbreviado= "CONSULTORÍA" },
                new Banco(){ Clave= "626", Institucion = "Deutsche Securities, S.A. de C.V.", NombreAbreviado= "CBDEUTSCHE" },
                new Banco(){ Clave= "627", Institucion = "Zurich Compañía de Seguros, S.A.", NombreAbreviado= "ZURICH" },
                new Banco(){ Clave= "628", Institucion = "Zurich Vida, Compañía de Seguros, S.A.", NombreAbreviado= "ZURICHVI" },
                new Banco(){ Clave= "629", Institucion = "Hipotecaria su Casita, S.A. de C.V.", NombreAbreviado= "SU CASITA" },
                new Banco(){ Clave= "630", Institucion = "Intercam Casa de Bolsa, S.A. de C.V.", NombreAbreviado= "C.B. INTERCAM" },
                new Banco(){ Clave= "631", Institucion = "CI Casa de Bolsa, S.A. de C.V.", NombreAbreviado= "C.I. BOLSA" },
                new Banco(){ Clave= "632", Institucion = "BULLTICK C.B.", NombreAbreviado= "Bulltick Casa de Bolsa, S.A. de C.V." },
                new Banco(){ Clave= "633", Institucion = "Sterling Casa de Cambio, S.A. de C.V.", NombreAbreviado= "STERLING" },
                new Banco(){ Clave= "634", Institucion = "Fincomún, Servicios Financieros Comunitarios, S.A. de C.V.", NombreAbreviado= "FINCOMUN" },
                new Banco(){ Clave= "636", Institucion = "HDI Seguros, S.A. de C.V.", NombreAbreviado= "HDI SEGUROS" },
                new Banco(){ Clave= "637", Institucion = "OrderExpress Casa de Cambio , S.A. de C.V. AAC", NombreAbreviado= "ORDER" },
                new Banco(){ Clave= "638", Institucion = "Akala, S.A. de C.V., Sociedad Financiera Popular", NombreAbreviado= "AKALA" },
                new Banco(){ Clave= "640", Institucion = "J.P. Morgan Casa de Bolsa, S.A. de C.V.", NombreAbreviado= "C.B. JP MORGAN" },
                new Banco(){ Clave= "642", Institucion = "Operadora de Recursos Reforma, S.A. de C.V.", NombreAbreviado= "REFORMA" },
                new Banco(){ Clave= "646", Institucion = "Sistema de Transferencias y Pagos STP, S.A. de C.V., SOFOM E.N.R.", NombreAbreviado= "STP" },
                new Banco(){ Clave= "647", Institucion = "Telecomunicaciones de México", NombreAbreviado= "TELECOMM" },
                new Banco(){ Clave= "648", Institucion = "Evercore Casa de Bolsa, S.A. de C.V.", NombreAbreviado= "EVERCORE" },
                new Banco(){ Clave= "649", Institucion = "Skandia Operadora S.A. de C.V.", NombreAbreviado= "SKANDIA" },
                new Banco(){ Clave= "651", Institucion = "Seguros Monterrey New York Life, S.A de C.V.", NombreAbreviado= "SEGMTY" },
                new Banco(){ Clave= "652", Institucion = "Solución Asea, S.A. de C.V., Sociedad Financiera Popular", NombreAbreviado= "ASEA" },
                new Banco(){ Clave= "653", Institucion = "Kuspit Casa de Bolsa, S.A. de C.V.", NombreAbreviado= "KUSPIT" },
                new Banco(){ Clave= "655", Institucion = "J.P. SOFIEXPRESS, S.A. de C.V., S.F.P.", NombreAbreviado= "SOFIEXPRESS" },
                new Banco(){ Clave= "656", Institucion = "UNAGRA, S.A. de C.V., S.F.P.", NombreAbreviado= "UNAGRA" },
                new Banco(){ Clave= "659", Institucion = "Opciones Empresariales Del Noreste, S.A. DE C.V.", NombreAbreviado= "OPCIONES EMPRESARIALES DEL NOROESTE" },
                new Banco(){ Clave= "670", Institucion = "Libertad Servicios Financieros, S.A. De C.V.", NombreAbreviado= "LIBERTAD" },
                new Banco(){ Clave= "674", Institucion = "AXA Seguros, S.A. De C.V.", NombreAbreviado= "AXA" },
                new Banco(){ Clave= "677", Institucion = "Caja Popular Mexicana, S.C. de A.P. de R.L. De C.V.", NombreAbreviado= "CAJA POP MEXICA" },
                new Banco(){ Clave= "679", Institucion = "Financiera Nacional De Desarrollo Agropecuario, Rural, F y P.", NombreAbreviado= "FND" },
                new Banco(){ Clave= "684", Institucion = "Operadora De Pagos Móviles De México, S.A. De C.V.", NombreAbreviado= "TRANSFER" },
                new Banco(){ Clave= "901", Institucion = "CLS Bank International", NombreAbreviado= "CLS" },
                new Banco(){ Clave= "902", Institucion = "SD. INDEVAL, S.A. de C.V.", NombreAbreviado= "INDEVAL" },
                new Banco(){ Clave= "999", Institucion = "N/A", NombreAbreviado= "N/A" },

           };

        public string Clave { get; set; }
        public string NombreAbreviado { get; set; }
        public string Institucion { get; set; }

        public static List<Banco> Listado()
        {

            return bancos;
        }
    }
}
