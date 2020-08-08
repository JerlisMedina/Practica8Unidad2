namespace Practica8Unidad2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inscripcion")]
    public partial class Inscripcion
    {
        public int Id { get; set; }

        public int? CursoId { get; set; }

        public int? EstudianteId { get; set; }

        public int? Semestre { get; set; }
    }
}
