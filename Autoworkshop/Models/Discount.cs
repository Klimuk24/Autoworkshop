namespace AutoWorkShop.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
