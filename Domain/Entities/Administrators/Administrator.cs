using Domain.Entities.Chat;
using Domain.Entities.Passvords;

namespace Domain.Entities.Administrators
{
    public class Administrator 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeLocation { get; set; }
    }
}
