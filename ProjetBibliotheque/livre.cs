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
    
    public partial class livre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public livre()
        {
            this.emprunters = new HashSet<emprunter>();
        }
    
        public int livre_ID { get; set; }
        public string livre_titre { get; set; }
        public Nullable<System.DateTime> livre_annee_parution { get; set; }
        public Nullable<int> genre_ID { get; set; }
        public Nullable<int> auteur_ID { get; set; }
        public Nullable<int> emplacement_ID { get; set; }
    
        public virtual auteur auteur { get; set; }
        public virtual emplacement emplacement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<emprunter> emprunters { get; set; }
        public virtual genre genre { get; set; }
    }
}