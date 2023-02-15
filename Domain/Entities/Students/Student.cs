using Domain.Entities.Chat;
using Domain.Entities.Dedlines;
using Domain.Entities.Groups;
using Domain.Entities.Passvords;
using Domain.Entities.Payments;

namespace Domain.Entities.Students
{
    public class Student 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Dedline> Dedline { get; set; }
        public List<Payment> payments { get; set; }
        public Student() 
        {
            Dedline= new List<Dedline>();
            payments= new List<Payment>();
        
        }

    }
}
