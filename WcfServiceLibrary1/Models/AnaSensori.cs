//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceLibrary1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnaSensori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnaSensori()
        {
            this.StoricoAllarmi = new HashSet<StoricoAllarmi>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdTipo { get; set; }
        public Nullable<bool> IsAbilitato { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoricoAllarmi> StoricoAllarmi { get; set; }
    }
}
