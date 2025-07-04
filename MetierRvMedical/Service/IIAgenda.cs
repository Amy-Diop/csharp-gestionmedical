﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical.Model;

namespace MetierRvMedical.Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IIAgenda" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IIAgenda
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: ajoutez vos opérations de service ici
        [OperationContract]
        bool UpdateAgenda(Agenda agenda);

        [OperationContract]
        bool AddAgenda(Agenda agenda);

        [OperationContract]
        List<Agenda> GetListeAgenda();

        [OperationContract]
        Medecin GetMedecinByID(int id);
    }
}
