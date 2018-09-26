//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoBiblioteca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Editorial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Editorial()
        {
            this.Libro = new HashSet<Libro>();
        }
    
        public int Id_editorial { get; set; }
        [Required(ErrorMessage ="Debe agregar un nombre de editorial")]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Debe agregar un pais")]
        [StringLength(100)]
        public string Pais { get; set; }
        [Required(ErrorMessage = "Debe agregar una dirección")]
        [StringLength(100)]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El número de teléfono es requerido")]
        [Phone]
        public string Telefono { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Libro> Libro { get; set; }
    }
}
