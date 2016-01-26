using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NrthWndService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShipperservice" in both code and config file together.
    [ServiceContract]
    public interface IShipperservice
    {
        [OperationContract]
        Shipper GetShipper(int id);
        [OperationContract]
        void SaveShipper(Shipper shipper);
    }
    [DataContract]
    public class Shipper
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public string Phone { get; set; }

    }
}
