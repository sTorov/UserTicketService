namespace UserTicketService
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Ticket(int id, string description, int price)
        {
            Id = id;
            Description = description;
            Price = price;
        }
    }
}
