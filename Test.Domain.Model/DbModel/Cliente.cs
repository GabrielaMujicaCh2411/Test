using System;
using System.Collections.Generic;

namespace Test.Domain.Model.DbModel
{
    public partial class Cliente
    {
        public int  ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoCliente { get; set; }
        public string SituacionLaboral { get; set; }
        public int? Estado { get; set; }
       
    }
}
