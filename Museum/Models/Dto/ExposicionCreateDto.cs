namespace Museum.Models.Dto
{
    public class ExposicionCreateDto
    {
        public DateTime Date { get; set; }


        public string Place { get; set; }


        //[JsonIgnore]
        public int AuthorId { get; set; }
    }
}
