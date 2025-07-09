using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace APIRvMedical.Model
{
    // Plus besoin de DbConfigurationType
    public class BdRvMedicalContext : DbContext
    {
        static BdRvMedicalContext()
        {
            // Enregistre le provider MySQL pour EF6
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
        }

        public BdRvMedicalContext() : base("name=bdRvMedicalContext") { }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Medecin> Medecins { get; set; }
        public DbSet<Secretaire> Secretaires { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<GroupeSanguin> GroupeSanguins { get; set; }
        public DbSet<Td_Erreur> Td_Erreurs { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
