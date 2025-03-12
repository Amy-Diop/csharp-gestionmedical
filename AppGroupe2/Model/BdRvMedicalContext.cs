using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace AppGroupe2.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdRvMedicalContext:DbContext
    {
        public BdRvMedicalContext() :base("bdRvMedicalContext") { }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DbSet<Medecin> Medecins { get; set; }

        public DbSet<Secretaire> Secretaires { get; set; }

        public DbSet<Agenda> Agenda { get; set; }

        public DbSet<RendezVous> RendezVous { get; set; }

        public DbSet<Specialite> Specialite { get; set; }

        public DbSet<GroupeSanguin> groupeSanguins { get; set; }

        public DbSet<Td_Erreur> td_Erreurs { get; set; }








    }
}
