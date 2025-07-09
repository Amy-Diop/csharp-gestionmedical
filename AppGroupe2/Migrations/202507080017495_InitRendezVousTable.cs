namespace AppGroupe2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitRendezVousTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("RendezVous", "IdPatient", "Personnes");
            AddColumn("RendezVous", "Patient_IdU", c => c.Int());
            CreateIndex("RendezVous", "Patient_IdU");
            AddForeignKey("RendezVous", "Patient_IdU", "Personnes", "IdU");
        }
        
        public override void Down()
        {
            DropForeignKey("RendezVous", "Patient_IdU", "Personnes");
            DropIndex("RendezVous", new[] { "Patient_IdU" });
            DropColumn("RendezVous", "Patient_IdU");
            AddForeignKey("RendezVous", "IdPatient", "Personnes", "IdU");
        }
    }
}
