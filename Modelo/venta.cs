//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaVentas.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class venta
    {
        public int idVenta { get; set; }
        public string tipopizza { get; set; }
        public string tamanopizza { get; set; }
        public string agregado2 { get; set; }
        public string tipobebida { get; set; }
        public string tamanobebida { get; set; }
        public int Trabajador_rut { get; set; }
        public int Cliente_idCliente { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual trabajador trabajador { get; set; }
    }
}
