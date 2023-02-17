
using Data.Migrations;
using Domain.Entities.Groups;

namespace service.Services.Administrator.GroupAdds
{
    public static class GroupAdd
    {
        public static void GAdd( string GName, string GDescription, string GroupDeyS, Teacher teachers)
        {
            Jamolar jamolar = new Jamolar() 
            {
                GroupName = GName,
                Description = GDescription,
                GroupDey = GroupDeyS,
                Teacher = teachers,

            };

        }
    }
}
