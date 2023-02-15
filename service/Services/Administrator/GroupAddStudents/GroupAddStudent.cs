using Data.O_quvMarkaziDbContext;

namespace service.Services.Administrator.GroupAddStudents
{
    public static class GroupAddStudent
    {
        public static void AddStudent(AppDbContext db,string groupName,string firstName ,string lastName)
        {
            var res = db.students.Where(p => p.FirstName== firstName && p.LastName == lastName).ToList();

        }
    }
}
