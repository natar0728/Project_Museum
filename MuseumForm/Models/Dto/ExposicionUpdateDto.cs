namespace Museum.Models.Dto
{
    public class ExposicionUpdateDto
    {
        public int Id { get; set; }


        public DateTime Date { get; set; }


        public string Place { get; set; }


        //[JsonIgnore]
        public int AuthorId { get; set; }

    }
}
