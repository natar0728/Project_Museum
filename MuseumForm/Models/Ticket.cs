using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models
{
    public class Ticket
    {

       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        public string Header { get; set; }

        //Hay que añadir mas atributos.......



        /*Quiza usar un List como con las aneteriores....*/
        //public int idExpo { get; set; }//Con este ya tengo la fehca y datos de la exposicion en teoría...
        ///**/
        //public Exposicion Exposicion { get; set; }



        public int ClientId { get; set; }
        public Client Client { get; set; }


        public DateTime FechaCompra { get; set; }
    }
       
}
