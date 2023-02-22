
using Data.O_quvMarkaziDbContext;
using Domain.Entities.Groups;
using Domain.Entities.Teachers;
using System.Xml.Linq;

namespace service.Services.Administrator
{
    public static class GroupAdd
    {
        public static void AddGrp(string grName,string GrInfo,string GDay,string TName)
        {
            AppDbContext db = new AppDbContext();
            var Teach = db.teachers.FirstOrDefault(p => p.FirstName == TName);

            Jamolar jamolar = new Jamolar()
            {
                GroupName = grName,
                Description = GrInfo,
                GroupDey = GDay,
                TeacherId = Teach.Id
            };

            db.group.Add(jamolar);
            db.SaveChanges();
        }
    }
}
