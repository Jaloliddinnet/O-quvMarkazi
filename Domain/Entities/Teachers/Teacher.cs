using Domain.Entities.Chat;
using Domain.Entities.Dedlines;
using Domain.Entities.Groups;
using Domain.Entities.Passvords;
using Domain.Entities.Payments;

namespace Domain.Entities.Teachers
{
    public class Teacher 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeLocation { get; set; }
        public List<Dedline> Dedline { get; set; }
        public List<Payment> Payment { get; set; }
        public virtual List<Jamolar> Groups { get; set; }
        public Teacher() 
        {
         
            Groups= new List<Jamolar>();
            Dedline = new List<Dedline>();
            Payment = new List<Payment>();
        }

    }
}
