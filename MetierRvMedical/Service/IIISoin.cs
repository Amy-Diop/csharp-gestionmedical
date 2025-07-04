using MetierRvMedical.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetierRvMedical.Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IIISoin" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IIISoin
    {

        [OperationContract]
        List<Soin> GetListeSoins();

        [OperationContract]
        bool AddSoin(Soin soin);

        [OperationContract]
        bool UpdateSoin(Soin soin);

        [OperationContract]
        void SupprimerSoin(int id);

        [OperationContract]
        Patient GetSoinById(int id);
    }
}
