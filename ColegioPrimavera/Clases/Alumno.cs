namespace ColegioPrimavera.Clases
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alumnos")]
    public partial class Alumno
    {
        [Key]
        public int Id_Alumnos { get; set; }

        [Required]
        [StringLength(45)]
        public string nombre_Alumno { get; set; }

        public DateTime nacimiento_Alumno { get; set; }

        public int Id_Curso { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
