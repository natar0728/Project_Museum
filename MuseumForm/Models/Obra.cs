using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models
{

    /*Puede ser una lista de autores en una obra*/
    public class Obra
    {
        
        public int Id { get; set; }

      
        public string Titulo { get; set; }
        
       
        public string Descripcion { get; set; }

   
        public string Tipo { get; set; }


        //[JsonIgnore]
        public int AuthorId { get; set; }
        public Autor Author { get; set; }


      // public List<Exposicion> Exposiciones { get; set; }

        // public ICollection<Autor> Autores { get; set; }//Obtener el o los autores de la obra(Relacion-Foreingkey)


    }
}
