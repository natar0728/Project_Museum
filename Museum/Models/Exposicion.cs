using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models
{

    /*Lista de obras de la exposicion*/

    //---------IMPORTAAAAAAANT:
    /*PARA OBTENER LAS OBRAS QUE ESTAN EN UNA EXPO SE DEBE HACER UN JOOIN/INNERJPIN A LAS TABLAS CREO...*/
    public class Exposicion
    {
        public int Id{ get; set; }

      
        public DateTime Date { get; set; }
        
        
        public string Place { get; set; }


        //[JsonIgnore]
        public int AuthorId { get; set; }
        public Autor Author { get; set; }

        //public List<Obra> obrasExpo { get; set; }//Obtener el listado de obras que se presentaran en la exposición (Relacion-Foreingkey).


        ///Maybe poner COllection de exposiciones a las que pertenece la obra
    }
}
