//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperZapatosConsole
{
    using System;
    using System.Collections.Generic;
    
    public partial class article
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public decimal total_in_shelf { get; set; }
        public decimal total_in_vault { get; set; }
        public int store_id { get; set; }
    
        public virtual store store { get; set; }
    }
}
