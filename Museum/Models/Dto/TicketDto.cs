namespace Museum.Models.Dto
{
    public class TicketDto
    {
        public int Id { get; set; }

        public string Header { get; set; }
        public int ClientId { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}
