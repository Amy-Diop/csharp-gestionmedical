using MetierRvMedical.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MetierRvMedical
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
       

            [OperationContract]
            string GetData(int value);

            [OperationContract]
            CompositeType GetDataUsingDataContract(CompositeType composite);
            [OperationContract]
            bool AddAgenda(Agenda agenda);
            [OperationContract]
            bool UpdateAgenda(Agenda agenda);
            [OperationContract]
            List<Agenda> GetListeAgenda();
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

        // TODO: ajoutez vos opérations de service ici


    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
        public class CompositeType
        {
            bool boolValue = true;
            string stringValue = "Hello ";

            [DataMember]
            public bool BoolValue
            {
                get { return boolValue; }
                set { boolValue = value; }
            }

            [DataMember]
            public string StringValue
            {
                get { return stringValue; }
                set { stringValue = value; }
            }
        }
    }
