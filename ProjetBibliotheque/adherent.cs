//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetBibliotheque
{
    using System;
    using System.Collections.Generic;
    
    public partial class adherent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public adherent()
        {
            this.emprunters = new HashSet<emprunter>();
        }
    
        public int adherent_ID { get; set; }
        public string adherent_nom { get; set; }
        public string adherent_prenom { get; set; }
        public Nullable<System.DateTime> adherent_date_naissance { get; set; }
        public string adherent_adresse { get; set; }
        public Nullable<int> adherent_code_postal { get; set; }
        public string adherent_ville { get; set; }
        public string adherent_telephone { get; set; }
        public string adherent_email { get; set; }
        public Nullable<System.DateTime> adherent_date_inscription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<emprunter> emprunters { get; set; }
    }
}
