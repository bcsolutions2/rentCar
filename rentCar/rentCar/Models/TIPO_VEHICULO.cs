//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
        [RegularExpression("[a-zA-Z ������������]+$", ErrorMessage = "Este campo solo acepta letras")]
        public string NOMBRE_TIPO_VEHICULO { get; set; }
        [Required]
        [RegularExpression("^(ACTIVO|INACTIVO)$", ErrorMessage = "Este campo solo acepta los valores ACTIVO o INACTIVO")]
        [Display(Name = "Estado"), StringLength(8, MinimumLength = 6, ErrorMessage = "Colocar ACTIVO o INACTIVO como estado")]
        public string ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEHICULO> VEHICULO { get; set; }
    }
}
