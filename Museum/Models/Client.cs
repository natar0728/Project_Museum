using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models
{
    public class Client
    {
        
        public int Id {get; set;}

       
        public string ClientName { get; set; }

        
        public string PhoneNumber { get; set; }


        //public int idTicket { get; set; }
        //public Ticket Ticket { get; set; }
        //public ICollection<Ticket> Tickets{ get; set; }

    }
}
