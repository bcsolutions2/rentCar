//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rentCar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class TIPO_VEHICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_VEHICULO()
        {
            this.VEHICULO = new HashSet<VEHICULO>();
        }

        public int ID_TIPO_VEHICULO { get; set; }
        [Display(Name = "Tipo de vehiculo"), StringLength(15, MinimumLength = 1)]
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Este campo solo acepta letras")]
        public string NOMBRE_TIPO_VEHICULO { get; set; }
        [Required]
        [RegularExpression("^(ACTIVO|INACTIVO)$", ErrorMessage = "Este campo solo acepta los valores ACTIVO o INACTIVO")]
        [Display(Name = "Estado"), StringLength(7, MinimumLength = 6,ErrorMessage = "Colocar ACTIVO o INACTIVO como estado")]
        public string ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEHICULO> VEHICULO { get; set; }
    }
}
