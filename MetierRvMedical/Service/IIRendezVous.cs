using System;
using System.Collections.Generic;
using System.ServiceModel;
using MetierRvMedical.Model;

namespace MetierRvMedical.Service
{
    [ServiceContract]
    public interface IIRendezVous
    {
        [OperationContract]
        RendezVous GetRendezVousById(int id);

        [OperationContract]
        bool AddRendezVous(RendezVous rv);

        [OperationContract]
        bool UpdateRendezVous(RendezVous rv);

        [OperationContract]
        void DeleteRendezVous(int id);

        [OperationContract]
        List<RendezVous> GetAllRendezVous();
    }
}
