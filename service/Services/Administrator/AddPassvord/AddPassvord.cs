using Data.O_quvMarkaziDbContext;
using Domain.Entities.Passvords;

namespace service.Services.Administrator.AddPassvord
{
    public static class AddPassvord
    {
        public static void AddPas(int ovnId,string Login,string pas,string rol)
        {
            AppDbContext dbContext = new AppDbContext();

            Passvord passvord = new Passvord() 
            {
                OvnId= ovnId,
                Login=Login,
                Password =pas,
                rols = rol
            };

            dbContext.passvords.Add(passvord);
            dbContext.SaveChanges();

        }
    }
}
