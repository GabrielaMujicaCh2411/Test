using System;
using System.Collections.Generic;

namespace Test.Domain.Model.DbModel
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int? IdCargo { get; set; }
        public decimal? Sueldo { get; set; }
        public string Afp { get; set; }
    }
}
