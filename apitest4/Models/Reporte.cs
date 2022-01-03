namespace apitest4.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Reporte")]
    public partial class Reporte
    {
        public int ReporteId { get; set; }

        public bool Mala_Conduccion { get; set; }

        public bool Acoso { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Nota { get; set; }

        [Required]
        [StringLength(10)]
        public string IdBus { get; set; }

        public int IdUsuario { get; set; }

        public virtual Bus Bus { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
