using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apitest4.Models
{
    [Table("Bus")]
    public partial class Bus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bus()
        {
            Parada = new HashSet<Parada>();
            Reporte = new HashSet<Reporte>();
            Resena = new HashSet<Resena>();
        }

        [Key]
        [StringLength(10)]
        public string Placa { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombres_Chofer { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombres_Asistente { get; set; }

        [Required]
        [StringLength(60)]
        public string Correo_Chofer { get; set; }

        [Required]
        [StringLength(60)]
        public string Correo_Asistente { get; set; }

        [Required]
        [StringLength(60)]
        public string Cedula_Chofer { get; set; }

        [Required]
        [StringLength(60)]
        public string Cedula_Asistente { get; set; }

        [Required]
        [StringLength(20)]
        public string Marca { get; set; }

        [Required]
        [StringLength(40)]
        public string Cooperativa { get; set; }

        public bool Wifi { get; set; }

        public bool TV { get; set; }

        public bool Baño { get; set; }

        public bool Asientos_discapacitados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parada> Parada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reporte> Reporte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resena> Resena { get; set; }
    }
}
