namespace Museum.Models.Dto
{
    public class TicketCreateDto
    {
        public string Header { get; set; }
        public int ClientId { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}
