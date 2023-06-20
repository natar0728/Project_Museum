namespace Museum.Models.Dto
{
    public class ObraDto
    {
        public int Id { get; set; }


        public string Titulo { get; set; }


        public string Descripcion { get; set; }


        public string Tipo { get; set; }


        //[JsonIgnore]
        public int AuthorId { get; set; }

        //public Autor Author { get; set; }
    }
}
