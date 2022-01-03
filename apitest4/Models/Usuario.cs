namespace apitest4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            
        }

        public int UsuarioId { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(40)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(60)]
        public string Correo { get; set; }

        [Required]
        [StringLength(60)]
        public string Contrasenia { get; set; }

        

        public bool Administrador { get; set; }
    }
}
