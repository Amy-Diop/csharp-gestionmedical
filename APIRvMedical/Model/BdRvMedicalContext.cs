using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace APIRvMedical.Model
{
    // Configure Entity Framework pour utiliser MySQL
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdRvMedicalContext : DbContext
    {
        public BdRvMedicalContext() : base("name=bdRvMedicalContext") { }

        // Tables de la base de données
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
        public DbSet<Soin> Soins { get; set; }
    }
}
