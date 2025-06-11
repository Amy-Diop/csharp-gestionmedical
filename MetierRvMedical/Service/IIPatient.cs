using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical.Model;

namespace MetierRvMedical.Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IIPatient" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IIPatient
    {
        [OperationContract]
        List<Patient> GetListePatients();

        [OperationContract]
        bool AddPatient(Patient patient);

        [OperationContract]
        bool UpdatePatient(Patient patient);

        [OperationContract]
        void SupprimerPatient(int id);

        [OperationContract]
        Patient GetPatientById(int id);
    }
}
