using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionNote
{
    [ServiceContract]
    interface ILogicClass
    {
        [OperationContract]
        int getEleve(int idEleves);
    }
}
