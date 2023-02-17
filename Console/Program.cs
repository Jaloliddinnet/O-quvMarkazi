

using Data.O_quvMarkaziDbContext;
using Domain.Entities.Administrators;
using Domain.Entities.Students;
using Domain.Entities.Teachers;

AppDbContext db = new AppDbContext();

Administrator Administrator = new Administrator() 
{
    FirstName = "Komiljon",
    LastName = "Ibodillayev",
    HomeLocation = "Samarqand"
};

db.Administrators.Add(Administrator);

Teacher Teacher = new Teacher() 
{
    FirstName = "Doniyor",
    LastName = "Hojiyev",
    HomeLocation = "Buhoro"
};

db.teachers.Add(Teacher);

Student Student = new Student() 
{
    FirstName = "Damir",
    LastName = "Bilmiman"

};

db.students.Add(Student);
db.SaveChanges();
