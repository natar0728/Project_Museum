using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Models
{

    /*Lista de obras del autor*/
    public class Autor
    {

        public Autor()
        {
            AuthorObras = new HashSet<Obra>();
        }


        public int Id { get; set; }

       
        public string Name { get; set; }


        public string LastName { get; set; }

       
        public string Email { get; set; }



        //[JsonIgnore]
        public ICollection<Obra> AuthorObras { get; set; }//Con esto obtener la info de las obras(Titulos mas que otra cosa. Relacion-Foreingkey).



    }
}
