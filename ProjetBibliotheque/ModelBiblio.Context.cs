﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BiblioEntities : DbContext
    {
        public BiblioEntities()
            : base("name=BiblioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adherent> adherents { get; set; }
        public virtual DbSet<auteur> auteurs { get; set; }
        public virtual DbSet<bibliothecaire> bibliothecaires { get; set; }
        public virtual DbSet<emplacement> emplacements { get; set; }
        public virtual DbSet<emprunter> emprunters { get; set; }
        public virtual DbSet<genre> genres { get; set; }
        public virtual DbSet<livre> livres { get; set; }
    
        public virtual int CreateAdherent(string nom, string prenom, Nullable<System.DateTime> dateNaissance, string adresse, string codePostal, string ville, string telephone, string email, Nullable<System.DateTime> dateInscription)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var dateNaissanceParameter = dateNaissance.HasValue ?
                new ObjectParameter("dateNaissance", dateNaissance) :
                new ObjectParameter("dateNaissance", typeof(System.DateTime));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("adresse", adresse) :
                new ObjectParameter("adresse", typeof(string));
    
            var codePostalParameter = codePostal != null ?
                new ObjectParameter("codePostal", codePostal) :
                new ObjectParameter("codePostal", typeof(string));
    
            var villeParameter = ville != null ?
                new ObjectParameter("ville", ville) :
                new ObjectParameter("ville", typeof(string));
    
            var telephoneParameter = telephone != null ?
                new ObjectParameter("telephone", telephone) :
                new ObjectParameter("telephone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var dateInscriptionParameter = dateInscription.HasValue ?
                new ObjectParameter("dateInscription", dateInscription) :
                new ObjectParameter("dateInscription", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateAdherent", nomParameter, prenomParameter, dateNaissanceParameter, adresseParameter, codePostalParameter, villeParameter, telephoneParameter, emailParameter, dateInscriptionParameter);
        }
    
        public virtual int CreateAuteur(string nom, string prenom)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateAuteur", nomParameter, prenomParameter);
        }
    
        public virtual int CreateBibliothecaire(string login, string password, string nom, string prenom)
        {
            var loginParameter = login != null ?
                new ObjectParameter("login", login) :
                new ObjectParameter("login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateBibliothecaire", loginParameter, passwordParameter, nomParameter, prenomParameter);
        }
    
        public virtual int CreateEmplacement(string libelle)
        {
            var libelleParameter = libelle != null ?
                new ObjectParameter("libelle", libelle) :
                new ObjectParameter("libelle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateEmplacement", libelleParameter);
        }
    
        public virtual int CreateEmprunt(Nullable<int> livreId, Nullable<int> adherentId, Nullable<System.DateTime> dateEmprunt, Nullable<System.DateTime> dateRetour)
        {
            var livreIdParameter = livreId.HasValue ?
                new ObjectParameter("livreId", livreId) :
                new ObjectParameter("livreId", typeof(int));
    
            var adherentIdParameter = adherentId.HasValue ?
                new ObjectParameter("adherentId", adherentId) :
                new ObjectParameter("adherentId", typeof(int));
    
            var dateEmpruntParameter = dateEmprunt.HasValue ?
                new ObjectParameter("dateEmprunt", dateEmprunt) :
                new ObjectParameter("dateEmprunt", typeof(System.DateTime));
    
            var dateRetourParameter = dateRetour.HasValue ?
                new ObjectParameter("dateRetour", dateRetour) :
                new ObjectParameter("dateRetour", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateEmprunt", livreIdParameter, adherentIdParameter, dateEmpruntParameter, dateRetourParameter);
        }
    
        public virtual int CreateGenre(string libelle)
        {
            var libelleParameter = libelle != null ?
                new ObjectParameter("libelle", libelle) :
                new ObjectParameter("libelle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateGenre", libelleParameter);
        }
    
        public virtual int CreateLivre(string titre, Nullable<System.DateTime> anneeParution, Nullable<int> genreId, Nullable<int> auteurId, Nullable<int> emplacementId)
        {
            var titreParameter = titre != null ?
                new ObjectParameter("titre", titre) :
                new ObjectParameter("titre", typeof(string));
    
            var anneeParutionParameter = anneeParution.HasValue ?
                new ObjectParameter("anneeParution", anneeParution) :
                new ObjectParameter("anneeParution", typeof(System.DateTime));
    
            var genreIdParameter = genreId.HasValue ?
                new ObjectParameter("genreId", genreId) :
                new ObjectParameter("genreId", typeof(int));
    
            var auteurIdParameter = auteurId.HasValue ?
                new ObjectParameter("auteurId", auteurId) :
                new ObjectParameter("auteurId", typeof(int));
    
            var emplacementIdParameter = emplacementId.HasValue ?
                new ObjectParameter("emplacementId", emplacementId) :
                new ObjectParameter("emplacementId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateLivre", titreParameter, anneeParutionParameter, genreIdParameter, auteurIdParameter, emplacementIdParameter);
        }
    
        public virtual ObjectResult<ReadAdherents_Result> ReadAdherents()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReadAdherents_Result>("ReadAdherents");
        }
    
        public virtual ObjectResult<ReadAuteurs_Result> ReadAuteurs()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReadAuteurs_Result>("ReadAuteurs");
        }
    
        public virtual ObjectResult<ReadBibliothecaires_Result> ReadBibliothecaires()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReadBibliothecaires_Result>("ReadBibliothecaires");
        }
    
        public virtual ObjectResult<ReadEmplacements_Result> ReadEmplacements()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReadEmplacements_Result>("ReadEmplacements");
        }
    
        public virtual ObjectResult<ReadEmprunts_Result> ReadEmprunts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReadEmprunts_Result>("ReadEmprunts");
        }
    
        public virtual ObjectResult<ReadGenres_Result> ReadGenres()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReadGenres_Result>("ReadGenres");
        }
    
        public virtual ObjectResult<ReadLivres_Result> ReadLivres()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReadLivres_Result>("ReadLivres");
        }
    }
}
