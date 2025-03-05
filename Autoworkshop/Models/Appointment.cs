namespace AutoWorkShop.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int MasterId { get; set; }
        public Master Master { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
