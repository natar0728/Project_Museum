namespace Museum.Models.Dto
{
    public class AutorDto
    {

        public int Id { get; set; }


        public string Name { get; set; }


        public string LastName { get; set; }


        public string Email { get; set; }



        //[JsonIgnore]
        //public ICollection<Obra> AuthorObras { get; set; }

    }
}
