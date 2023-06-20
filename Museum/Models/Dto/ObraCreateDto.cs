namespace Museum.Models.Dto
{
    public class ObraCreateDto
    {
        public string Titulo { get; set; }


        public string Descripcion { get; set; }


        public string Tipo { get; set; }


        //[JsonIgnore]
        public int AuthorId { get; set; }
    }
}
