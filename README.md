# ValidaCLABE
Librería que realiza la validación de una  Clave Bancaria Estandarizada (CLABE) 
La libreria realiza la validación del digito verificador y adicionalmente proporciona información del banco, sucursal y número de cuenta.

**Validación CLABE**
```
 ValidacionResult result = ValidarCLABE.Validar("000000000000000000");
 
 ===========================================================
CLABE Valida:True
CLABE Mensaje Error:
Número Cuenta:00286054841
Banco:127
AZTECA
Banco Azteca, S.A.
Sucrusal: 050
===========================================================
```
**Litado de bancos**
La libreria te proporciona el listado de bancos registrado por la  Asociación de Bancos de México - ABM a traves de un metodos estatico de la clase Banco.cs
```
Banco.Listado();
========================Listado de Bancos===================
Clave:002 Nombre:BANAMEX Institución:Banco Nacional de México, S.A.
Clave:006 Nombre:BANCOMEXT Institución:Banco Nacional de Comercio Exterior
Clave:009 Nombre:BANOBRAS Institución:Banco Nacional de Obras y Servicios Públicos
Clave:012 Nombre:BBVA BANCOMER Institución:BBVA Bancomer, S.A.
Clave:014 Nombre:SANTANDER Institución:Banco Santander, S.A.
Clave:019 Nombre:BANJERCITO Institución:Banco Nacional del Ejército, Fuerza Aérea y Armada
Clave:021 Nombre:HSBC Institución:HSBC México, S.A.
Clave:022 Nombre:GE MONEY Institución:GE Money Bank, S.A.
Clave:030 Nombre:BAJÍO Institución:Banco del Bajío, S.A.
Clave:032 Nombre:IXE Institución:IXE Banco, S.A.
Clave:036 Nombre:INBURSA Institución:Banco Inbursa, S.A.
Clave:037 Nombre:INTERACCIONES Institución:Banco Interacciones, S.A.
Clave:042 Nombre:MIFEL Institución:Banca Mifel, S.A.
Clave:044 Nombre:SCOTIABANK Institución:Scotiabank Inverlat, S.A.
Clave:058 Nombre:BANREGIO Institución:Banco Regional de Monterrey, S.A.
Clave:059 Nombre:INVEX Institución:Banco Invex, S.A.
Clave:060 Nombre:BANSI Institución:Bansi, S.A.
Clave:062 Nombre:AFRIME Institución:Banca Afirme, S.A.
Clave:072 Nombre:BANORTE Institución:Banco Mercantil del Norte, S.A.
Clave:102 Nombre:THE ROYAL BANK Institución:The Royal Bank of Scotland México, S.A.
Clave:103 Nombre:AMERICAN EXPRESS Institución:American Express Bank (México), S.A.
Clave:106 Nombre:BAMSA Institución:Bank of America México, S.A.
Clave:108 Nombre:TOKYO Institución:Bank of Tokyo-Mitsubishi UFJ (México), S.A.
Clave:108 Nombre:JP MORGAN Institución:Banco J.P. Morgan, S.A.
Clave:112 Nombre:BMONEX Institución:Banco Monex, S.A.
Clave:113 Nombre:VE POR MAS Institución:Banco Ve por Mas, S.A.
Clave:116 Nombre:ING Institución:ING Bank (México), S.A.
Clave:124 Nombre:DEUTSCHE Institución:Deutsche Bank México, S.A.
Clave:126 Nombre:CREDIT SUISSE Institución:Banco Credit Suisse (México), S.A.
Clave:127 Nombre:AZTECA Institución:Banco Azteca, S.A.
Clave:128 Nombre:AUTOFIN Institución:Banco Autofin México, S.A.
Clave:129 Nombre:BARCLAYS Institución:Barclays Bank México, S.A.
Clave:130 Nombre:COMPARTAMOS Institución:Banco Compartamos, S.A.
Clave:131 Nombre:FAMSA Institución:Banco Ahorro Famsa, S.A.
Clave:132 Nombre:BMULTIVA Institución:Banco Multiva, S.A.
Clave:133 Nombre:ACTINVER Institución:Banco Actinver, S.A.
Clave:134 Nombre:WAL-MART Institución:Banco Wal Mart de México Adelante, S.A.
Clave:135 Nombre:NAFIN Institución:Nacional Financiera, S.N.C.
Clave:136 Nombre:INTERBANCO Institución:Inter Banco, S.A.
Clave:137 Nombre:BANCOPPEL Institución:BanCoppel, S.A.
Clave:138 Nombre:ABC CAPITAL Institución:ABC Capital, S.A. I.B.M.
Clave:139 Nombre:UBS BANK Institución:UBS Banco, S.A.
Clave:140 Nombre:CONSUBANCO Institución:Consubanco, S.A.
Clave:141 Nombre:VOLKSWAGEN Institución:Volkswagen Bank S.A. Institución de Banca Múltiple
Clave:143 Nombre:CIBanco Institución:Consultoría Internacional Banco, S.A.
Clave:145 Nombre:BBASE Institución:Banco BASE, S.A. de I.B.M.
Clave:147 Nombre:BANKAOOL Institución:Bankaool, S.A., Institución de Banca Múltiple
Clave:148 Nombre:PagaTodo Institución:Banco PagaTodo S.A., Institución de Banca Múltiple
Clave:150 Nombre:BIM Institución:Banco Inmobiliario Mexicano, S.A., Institución de Banca Múltiple
Clave:155 Nombre:ICBC Institución:Industrial and Commercial Bank of China, S.A., Institución de Banca Múltiple
Clave:156 Nombre:SABADELL Institución:Banco Sabadell, S.A. I.B.M.
Clave:166 Nombre:BANSEFI Institución:Banco del Ahorro Nacional y Servicios Financieros, S.N.C.
Clave:168 Nombre:HIPOTECARIA FEDERAL Institución:Banco del Ahorro Nacional y Servicios Financieros, S.N.C.
Clave:600 Nombre:MONEXCB Institución:Monex Casa de Bolsa, S.A. de C.V.
Clave:601 Nombre:GBM Institución:GBM Grupo Bursátil Mexicano, S.A. de C.V.
Clave:602 Nombre:MASARI CB Institución:Masari Casa de Bolsa, S.A.
Clave:604 Nombre:C.B. INBURSA Institución:Inversora Bursátil, S.A. de C.V.
Clave:605 Nombre:VALUÉ Institución:Valué, S.A. de C.V., Casa de Bolsa
Clave:606 Nombre:ESTRUCTURADORES Institución:Estructuradores del Mercado de Valores Casa de Bolsa, S.A. de C.V.
Clave:607 Nombre:TIBER Institución:Casa de Cambio Tiber, S.A. de C.V.
Clave:608 Nombre:VECTOR Institución:Vector Casa de Bolsa, S.A. de C.V.
Clave:610 Nombre:B&B Institución:B y B Casa de Cambio, S.A. de C.V.
Clave:611 Nombre:INTERCAM Institución:Intercam Casa de Cambio, S.A. de C.V.
Clave:613 Nombre:MULTIVA Institución:Multivalores Casa de Bolsa, S.A. de C.V. Multiva Gpo. Fin.
Clave:614 Nombre:ACCIVAL Institución:Acciones y Valores Banamex, S.A. de C.V., Casa de Bolsa
Clave:615 Nombre:MERRILL LYNCH Institución:Merrill Lynch México, S.A. de C.V., Casa de Bolsa
Clave:616 Nombre:FINAMEX Institución:Casa de Bolsa Finamex, S.A. de C.V.
Clave:617 Nombre:VALMEX Institución:Valores Mexicanos Casa de Bolsa, S.A. de C.V.
Clave:618 Nombre:ÚNICA Institución:Única Casa de Cambio, S.A. de C.V.
Clave:619 Nombre:MAPFRE Institución:MAPFRE Tepeyac S.A.
Clave:620 Nombre:PROFUTURO Institución:Profuturo G.N.P., S.A. de C.V.
Clave:621 Nombre:CB ACTINBER Institución:Actinver Casa de Bolsa, S.A. de C.V.
Clave:622 Nombre:OACTIN Institución:OPERADORA ACTINVER, S.A. DE C.V.
Clave:623 Nombre:SKANDIA Institución:Skandia Vida S.A. de C.V.
Clave:624 Nombre:CONSULTORÍA Institución:Consultoría Internacional Casa de Cambio, S.A. de C.V.
Clave:626 Nombre:CBDEUTSCHE Institución:Deutsche Securities, S.A. de C.V.
Clave:627 Nombre:ZURICH Institución:Zurich Compañía de Seguros, S.A.
Clave:628 Nombre:ZURICHVI Institución:Zurich Vida, Compañía de Seguros, S.A.
Clave:629 Nombre:SU CASITA Institución:Hipotecaria su Casita, S.A. de C.V.
Clave:630 Nombre:C.B. INTERCAM Institución:Intercam Casa de Bolsa, S.A. de C.V.
Clave:631 Nombre:C.I. BOLSA Institución:CI Casa de Bolsa, S.A. de C.V.
Clave:632 Nombre:Bulltick Casa de Bolsa, S.A. de C.V. Institución:BULLTICK C.B.
Clave:633 Nombre:STERLING Institución:Sterling Casa de Cambio, S.A. de C.V.
Clave:634 Nombre:FINCOMUN Institución:Fincomún, Servicios Financieros Comunitarios, S.A. de C.V.
Clave:636 Nombre:HDI SEGUROS Institución:HDI Seguros, S.A. de C.V.
Clave:637 Nombre:ORDER Institución:OrderExpress Casa de Cambio , S.A. de C.V. AAC
Clave:638 Nombre:AKALA Institución:Akala, S.A. de C.V., Sociedad Financiera Popular
Clave:640 Nombre:C.B. JP MORGAN Institución:J.P. Morgan Casa de Bolsa, S.A. de C.V.
Clave:642 Nombre:REFORMA Institución:Operadora de Recursos Reforma, S.A. de C.V.
Clave:646 Nombre:STP Institución:Sistema de Transferencias y Pagos STP, S.A. de C.V., SOFOM E.N.R.
Clave:647 Nombre:TELECOMM Institución:Telecomunicaciones de México
Clave:648 Nombre:EVERCORE Institución:Evercore Casa de Bolsa, S.A. de C.V.
Clave:649 Nombre:SKANDIA Institución:Skandia Operadora S.A. de C.V.
Clave:651 Nombre:SEGMTY Institución:Seguros Monterrey New York Life, S.A de C.V.
Clave:652 Nombre:ASEA Institución:Solución Asea, S.A. de C.V., Sociedad Financiera Popular
Clave:653 Nombre:KUSPIT Institución:Kuspit Casa de Bolsa, S.A. de C.V.
Clave:655 Nombre:SOFIEXPRESS Institución:J.P. SOFIEXPRESS, S.A. de C.V., S.F.P.
Clave:656 Nombre:UNAGRA Institución:UNAGRA, S.A. de C.V., S.F.P.
Clave:659 Nombre:OPCIONES EMPRESARIALES DEL NOROESTE Institución:Opciones Empresariales Del Noreste, S.A. DE C.V.
Clave:670 Nombre:LIBERTAD Institución:Libertad Servicios Financieros, S.A. De C.V.
Clave:674 Nombre:AXA Institución:AXA Seguros, S.A. De C.V.
Clave:677 Nombre:CAJA POP MEXICA Institución:Caja Popular Mexicana, S.C. de A.P. de R.L. De C.V.
Clave:679 Nombre:FND Institución:Financiera Nacional De Desarrollo Agropecuario, Rural, F y P.
Clave:684 Nombre:TRANSFER Institución:Operadora De Pagos Móviles De México, S.A. De C.V.
Clave:901 Nombre:CLS Institución:CLS Bank International
Clave:902 Nombre:INDEVAL Institución:SD. INDEVAL, S.A. de C.V.
Clave:999 Nombre:N/A Institución:N/A
===========================================================
```
