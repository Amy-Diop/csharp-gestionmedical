using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical.Model;

namespace MetierRvMedical.Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IIMedecin" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IIMedecin
    {
        [OperationContract]
        Medecin GetMedecinById(int id);
        [OperationContract]
        bool AddMedecin(Medecin medecin);
        [OperationContract]
        Role GetRoleById(int id);
        [OperationContract]
        Role GetRoleByCode(string code);

        [OperationContract]
        bool UpdateMedecin(Medecin agenda);
        [OperationContract]
        List<Medecin> GetListeMedecin();
        [OperationContract]
        void SupprimerMedecin(int id);

        [OperationContract]
        List<Specialite> GetAllSpecialites();

    }
}
