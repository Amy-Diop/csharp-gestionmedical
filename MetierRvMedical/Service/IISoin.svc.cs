using MetierRvMedical.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetierRvMedical.Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "IISoin" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez IISoin.svc ou IISoin.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class IISoin : IIISoin
    {
        public bool AddSoin(Soin soin)
        {
            throw new NotImplementedException();
        }

        public List<Soin> GetListeSoins()
        {
            throw new NotImplementedException();
        }

        public Patient GetSoinById(int id)
        {
            throw new NotImplementedException();
        }

        public void SupprimerSoin(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSoin(Soin soin)
        {
            throw new NotImplementedException();
        }
    }
}
