//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_Laboratorios
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservacion
    {
        public int N_Reservacion { get; set; }
        public string Empleado { get; set; }
        public string Aula { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaReservacion { get; set; }
        public string Cantidad_horas { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; }
    }
}
