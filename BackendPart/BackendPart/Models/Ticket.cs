using System;
using System.Runtime.Serialization;

namespace BackendPart.Models
{
    [Serializable]
    [DataContract]
    public class Ticket
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int QuantitySold { get; set; }
        [DataMember]
        public DateTime SalesTime { get; set; }

        public Ticket()
        {

        }
    }
}