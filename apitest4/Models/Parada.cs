namespace apitest4.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Parada")]
    public partial class Parada
    {
        public int ParadaId { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(40)]
        public string Sector { get; set; }

        [Column(TypeName = "money")]
        public decimal? Costo { get; set; }

        [Required]
        [StringLength(10)]
        public string IdBus { get; set; }

        public virtual Bus Bus { get; set; }
    }
}
