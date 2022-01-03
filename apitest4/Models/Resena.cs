namespace apitest4.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Resena")]
    public partial class Resena
    {
        public int ResenaId { get; set; }

        public int? Calificacion { get; set; }

        [Column(TypeName = "text")]
        public string Nota { get; set; }

        [Required]
        [StringLength(10)]
        public string IdBus { get; set; }

        public int IdUsuario { get; set; }

        public virtual Bus Bus { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
