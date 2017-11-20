using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BackendPart.Models
{

    [Serializable]
    [DataContract]
    public class Movie
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime StarOfShow { get; set; }
        [DataMember]
        public ICollection<Ticket> SoldTickets { get; set; }

        public Movie()
        {
            SoldTickets = new List<Ticket>();
        }
    }
}