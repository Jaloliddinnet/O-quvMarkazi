using Data.O_quvMarkaziDbContext;
using Domain.Entities.Payments;

namespace service.Services.Administrator.AddPAyments
{
    public static class AddPay
    {
        public static void AddPaym(string grupName , string firstName,string lastName , int PaymenAmount)
        {
            AppDbContext db = new AppDbContext();
            var res = db.students.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);
            var teach = db.group.FirstOrDefault(p => p.GroupName== grupName);

            Payment payment = new Payment()
            {
                PaymentMany = PaymenAmount,
                PaymentData = DateTime.Now
            };

            res.payments.Add(payment);
            teach.Teacher.Payment.Add(payment);
            db.SaveChanges();
        }
    }
}
