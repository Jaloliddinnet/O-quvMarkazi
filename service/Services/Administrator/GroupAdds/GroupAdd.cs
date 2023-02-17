
using Data.O_quvMarkaziDbContext;
using Domain.Entities.Groups;
using Domain.Entities.Teachers;

namespace service.Services.Administrator.GroupAdds
{
    public static class GroupAdd
    {
        public static void GAdd( string GName, string GDescription, string GroupDeyS)
        {
            AppDbContext db = new AppDbContext();
            Jamolar jamolar = new Jamolar() 
            {
                GroupName = GName,
                Description = GDescription,
                GroupDey = GroupDeyS,
            };
            db.group.Add(jamolar);
            db.SaveChanges();
        }
    }
}
