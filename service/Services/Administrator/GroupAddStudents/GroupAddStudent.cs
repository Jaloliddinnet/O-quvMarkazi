using Data.O_quvMarkaziDbContext;

namespace service.Services.Administrator.GroupAddStudents
{
    public static class GroupAddStudent
    {
        public static void AddStudent(AppDbContext db,string groupName,string firstName ,string lastName)
        {
            var res = db.students.FirstOrDefault(p => p.FirstName== firstName && p.LastName == lastName);

            var grup = db.group.FirstOrDefault(p => p.GroupName== groupName);
            
           grup.Students.Add(res);
            db.SaveChanges();
        }

    }
}
