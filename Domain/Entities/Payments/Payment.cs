using Domain.Entities.Students;
using Domain.Entities.Teachers;

namespace Domain.Entities.Payments
{
    public class Payment
    {
        public int Id { get; set; }
        public int PaymentMany { get; set; }
        public DateTime PaymentData { get; set; } 
        public bool ChakPoint { get; set; }
        public Student student { get; set; }
    }
}