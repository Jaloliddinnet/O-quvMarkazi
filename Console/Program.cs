using Data.O_quvMarkaziDbContext;
using Domain.Entities.Administrators;
using Domain.Entities.Dedlines;
using Domain.Entities.Groups;
using Domain.Entities.Passvords;
using Domain.Entities.Payments;
using Domain.Entities.Students;
using Domain.Entities.Teachers;
using Microsoft.EntityFrameworkCore;

AppDbContext db = new AppDbContext();


Console.Write("Login: ");
string login = Console.ReadLine();
Console.WriteLine();

Console.Write("Passvord: ");
string Pass = Console.ReadLine();
Console.WriteLine();

var res = db.passvords.FirstOrDefault(x => (x.Login == login && x.Password == Pass));
if (res == null)
{
    Console.WriteLine("Login yoki parol xato");
}
else if (res.rols == "Administrator")
{
    var Ad = db.Administrators.FirstOrDefault(x => x.Id == res.OvnId);
    Console.WriteLine("Assalom alaykum  " + Ad.FirstName);
    while (true)
    {
        AdministratorMenyu();
        int a = int.Parse(Console.ReadLine());


        switch (a)
        {
            case 1:
                {
                    while (true)
                    {
                        db.group.ForEachAsync(p =>
                        {
                            Console.WriteLine($"{p.GroupName} \n\t {p.Description} \n\t ");
                        });

                        GrupKomn();
                        string koman = Console.ReadLine();
                        if (koman == "0") break;
                        switch (koman)
                        {
                            case "add":
                                {
                                    Console.Write("Group name : ");
                                    string grName = Console.ReadLine();
                                    Console.Write("Group info : ");
                                    string GrInfo = Console.ReadLine();
                                    Console.Write("Group day: ");
                                    string GDay = Console.ReadLine();
                                    Console.Write("Teacher Firsname: ");
                                    string TName = Console.ReadLine();

                                    var teach = db.teachers.FirstOrDefault(p => p.FirstName == TName);

                                    
                                    Jamolar jamolar= new Jamolar() 
                                    {
                                        GroupName = grName,
                                        Description = GrInfo,
                                        GroupDey = GDay,
                                        TeacherId = teach.Id,
                                        Created = DateTime.Now,
                                    };

                                    db.group.Add(jamolar);
                                    db.SaveChanges();
                                    break;
                                }
                            case "update":
                                {

                                    string GNam = Console.ReadLine();

                                    Console.Write("Group name : ");
                                    string grName = Console.ReadLine();
                                    Console.Write("Group info : ");
                                    string GrInfo = Console.ReadLine();
                                    Console.Write("Group day: ");
                                    string GDay = Console.ReadLine();
                                    Console.Write("Teacher Firsname: ");
                                    string TName = Console.ReadLine();

                                    var teach = db.teachers.FirstOrDefault(p => p.FirstName == TName);

                                    var GrUP = db.group.FirstOrDefault(p => p.GroupName == GNam);

                                    GrUP.GroupName = grName;
                                    GrUP.Description = GrInfo;
                                    GrUP.GroupDey = GDay;
                                    GrUP.TeacherId = teach.Id;

                                    db.SaveChanges();

                                    break;
                                }
                            case "delete":
                                {

                                    string GName = Console.ReadLine();

                                    var Grp = db.group.FirstOrDefault(p => p.GroupName == GName);
                                    db.group.Remove(Grp);

                                    break;
                                }
                                
                        }

                    }
                    break;
                }
            case 2:
                {


                    db.teachers.ForEachAsync(p =>
                    {
                        Console.WriteLine($" {p.Id} \t {p.FirstName} \t {p.LastName} \t  {p.HomeLocation}");
                    });

                    GrupKomn();
                    string koman = Console.ReadLine();
                    switch (koman)
                    {
                        case "add":
                            {
                                Console.Write("First name : ");
                                string FirstName = Console.ReadLine();
                                Console.Write("Last name : ");
                                string LastName = Console.ReadLine();
                                Console.Write("Home Location : ");
                                string HomeLocation = Console.ReadLine();

                                Teacher teacher = new Teacher()
                                {
                                    FirstName = FirstName,
                                    LastName = LastName,
                                    HomeLocation = HomeLocation
                                };

                                db.teachers.Add(teacher);
                                db.SaveChanges();

                                break;
                            }
                        case "update":
                            {
                                string LNteach = Console.ReadLine();

                                Console.Write("First name : ");
                                string FirstName = Console.ReadLine();
                                Console.Write("Last name : ");
                                string LastName = Console.ReadLine();
                                Console.Write("Home Location : ");
                                string HomeLocation = Console.ReadLine();

                                var teach = db.teachers.FirstOrDefault(p => p.FirstName == LNteach);

                                teach.FirstName = FirstName;
                                teach.LastName = LastName;
                                teach.HomeLocation = HomeLocation;

                                db.SaveChanges();

                                break;
                            }
                        case "delete":
                            {

                                string FirstName = Console.ReadLine();
                                string LastName = Console.ReadLine();

                               var teach = db.teachers.FirstOrDefault(p => p.FirstName == FirstName && p.LastName == LastName);

                                db.teachers.Remove(teach);

                                break;
                            }
                            if (koman == "0") break;


                    }
                    break;

                }
            case 3:
                {
                    db.students.ForEachAsync(p =>
                    {
                        Console.WriteLine($" {p.Id} \t {p.FirstName} \t {p.LastName} ");
                    });

                    GrupKomn();
                    string koman = Console.ReadLine();
                    switch (koman)
                    {
                        case "add":
                            {
                                Console.Write("First name : ");
                                string FirstName = Console.ReadLine();
                                Console.Write("Last name : ");
                                string LastName = Console.ReadLine();

                                Student student = new Student()
                                {
                                    FirstName = FirstName,
                                    LastName = LastName,
                                };

                                db.students.Add(student);
                                db.SaveChanges();

                                break;
                            }
                        case "update":
                            {
                                string LNteach = Console.ReadLine();
                                
                                var teach = db.students.FirstOrDefault(p => p.FirstName == LNteach);

                                Console.Write("First name : ");
                                teach.FirstName = Console.ReadLine();
                                Console.Write("Last name : ");
                                teach.LastName = Console.ReadLine();


                                db.SaveChanges();

                                break;
                            }
                        case "delete":
                            {

                                string FirstName = Console.ReadLine();
                                string LastName = Console.ReadLine();

                                var stu = db.students.FirstOrDefault(s => s.FirstName == FirstName && LastName == LastName);

                                db.students.Remove(stu);

                                break;
                            }
                            if (koman == "0") break;
                    }
                    break;
                }
            case 4:
                {
                    db.Administrators.ForEachAsync(p =>
                    {
                        Console.WriteLine($" {p.Id} \t {p.FirstName} \t {p.LastName} \t {p.HomeLocation}");
                    });

                    GrupKomn();
                    string koman = Console.ReadLine();
                    switch (koman)
                    {
                        case "add":
                            {
                                Console.Write("First name : ");
                                string FirstName = Console.ReadLine();
                                Console.Write("Last name : ");
                                string LastName = Console.ReadLine();
                                Console.Write("Home Location : ");
                                string HomeLocation = Console.ReadLine();


                                Administrator administrator = new Administrator()
                                {
                                    FirstName = FirstName,
                                    LastName = LastName,
                                    HomeLocation = HomeLocation
                                };

                                db.Administrators.Add(administrator);
                                db.SaveChanges();

                                break;
                            }
                        case "update":
                            {
                                string LNteach = Console.ReadLine();

                                var teach = db.Administrators.FirstOrDefault(p => p.FirstName == LNteach);

                                Console.Write("First name : ");
                                teach.FirstName = Console.ReadLine();
                                Console.Write("Last name : ");
                                teach.LastName = Console.ReadLine();
                                Console.Write("Home Location : ");
                                teach.HomeLocation = Console.ReadLine();
                               

                                db.SaveChanges();

                                break;
                            }
                        case "delete":
                            {

                                string FirstName = Console.ReadLine();
                                string LastName = Console.ReadLine();

                                var admin = db.Administrators.FirstOrDefault(p => p.FirstName == FirstName && p.LastName == LastName);

                                db.Administrators.Remove(admin);

                                break;
                            }
                            if (koman == "0") break;
                    }
                    break;
                }
            case 5:
                {
                    Console.Write("First name : ");
                    string firstNmae = Console.ReadLine();
                    Console.Write("Last name : ");
                    string lastNmae = Console.ReadLine();
                    Console.Write("Login : ");
                    string log = Console.ReadLine();
                    Console.Write("Passvord : ");
                    string pass = Console.ReadLine();
                    Passvord();
                    Console.Write("Rol : ");
                    string rol = Console.ReadLine();
                    int sum = 0;
                    if(rol == "Administrator") 
                    {
                    var te = db.Administrators.FirstOrDefault(p => p.FirstName == firstNmae && p.LastName == lastNmae);
                        sum = te.Id;
                    }
                    else if (rol == "Teacher")
                    {
                        var te = db.teachers.FirstOrDefault(p => p.FirstName == firstNmae && p.LastName == lastNmae);
                        sum = te.Id;
                    }
                    else if (rol == "Students")
                    {
                        var te = db.students.FirstOrDefault(p => p.FirstName == firstNmae && p.LastName == lastNmae);
                        sum = te.Id;
                    }

                    Passvord passvord = new Passvord()
                    {
                        OvnId = sum,
                        Password = pass,
                        Login = log,
                        rols = rol
                    };

                    db.passvords.Add(passvord);
                    db.SaveChanges();

                    break;
                }
            case 6:
                {
                    Console.WriteLine("Group name : ");
                     string GName = Console.ReadLine();
                    var GroupAdd = db.group.FirstOrDefault(p => p.GroupName== GName);

                    Console.Write("First name : ");
                    string firstName = Console.ReadLine();
                    Console.Write("Last name : ");
                    string lastName = Console.ReadLine();
                    var stu = db.students.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);

                    GroupAdd.Students.Add(stu);
                    db.SaveChanges();
                    Console.Write("Add");

                    break;
                }
            case 7:
                {

                    Console.Write("Group name : ");
                    string Gname = Console.ReadLine();
                    Console.Write("First name : ");
                    string firsName = Console.ReadLine();
                    Console.Write("Last name : ");
                    string lastName = Console.ReadLine();
                    Console.Write("How many : ");
                    string many = Console.ReadLine();

                    var re = db.students.FirstOrDefault(p => p.FirstName == firsName && p.LastName == lastName);
                    var tech = db.group.FirstOrDefault(p => p.GroupName == Gname);

                    Payment payment = new Payment() 
                    {
                        PaymentMany = int.Parse(many),
                        PaymentData = DateTime.Now,
                    };

                    tech.Teacher.Payment.Add(payment); 
                    re.payments.Add(payment);
                    db.SaveChanges();

                    break;
                }
        }
    }
}
else if (res.rols == "Teacher")
{
    var Ad = db.teachers.FirstOrDefault(x => x.Id == res.OvnId);
    Console.WriteLine("Assalom alaykum  " + Ad.FirstName );
    while (true)
    {
        TeacherMenyu();
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                {
                    List<Jamolar> jamolars = db.group.Where(p => p.Teacher.FirstName == Ad.FirstName).ToList();
                    jamolars.ForEach(p => 
                    {
                        Console.WriteLine($"{p.GroupName} | {p.Description} | {p.GroupDey} ");
                    });
                    break;
                }
                case 2:
                {
                    Console.Write("Group name : ");
                    string Gname = Console.ReadLine();
                    Console.Write("Dedline url : ");
                    string url = Console.ReadLine();
                    Console.Write("Dedline info : ");
                    string info = Console.ReadLine();
                    Console.Write("00:00:00 : ");
                    TimeSpan timeSpan =TimeSpan.Parse(Console.ReadLine());

                    var gr = db.group.FirstOrDefault(p => p.GroupName == Gname);

                    Dedline dedline = new Dedline() 
                    {
                        DedlineUrl = url,
                        DedlineInfo = info,
                        GroupId = gr.Id,
                        Time = DateTime.Now,
                        DedlineTime = timeSpan,
                    };

                    
                    db.Dedline.Add( dedline );
                    db.SaveChanges();

                    break;
                }
            case 3:
                {
                    int sum = 0;

                    foreach(var x in Ad.Payment)
                    {
                        Console.WriteLine($"{x.student.FirstName} | {x.student.LastName} | {x.PaymentMany}");
                        sum += x.PaymentMany;
                    }

                    Console.WriteLine($"\n\nSizning summangiz {(float)sum * 0.45 }");
                    break;
                }

        }
    }
}
else if (res.rols == "Student")
{
    var Ad = db.students.FirstOrDefault(x => x.Id == res.OvnId);
    Console.WriteLine("Assalom alaykum  " + Ad.FirstName);
    while (true)
    {
        StudentMenyu();
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                {
                    var grp = db.students.FirstOrDefault(p => p.Id == res.OvnId);
                    grp.groups.ForEach(p => Console.WriteLine($"{p.GroupName}"));
                    break;
                }
            case 2:
                {

                    break;
                }

        }
    }
}

static void StudentMenyu()
{
    Console.WriteLine("1 - Group");
    Console.WriteLine("2 - Dedline");
}
static void TeacherMenyu()
{
    Console.WriteLine("1 - Group");
    Console.WriteLine("2 - Dedline");
    Console.WriteLine("3 - Payment sum");
}
static void AdministratorMenyu()
{
    Console.WriteLine("1 - Gruppalar");
    Console.WriteLine("2 - O'qituvchilar");
    Console.WriteLine("3 - O'quvchilar");
    Console.WriteLine("4 - Administratorlar");
    Console.WriteLine("5 - Login and Passvord Add");
    Console.WriteLine("6 - Group add students");
    Console.WriteLine("7 - Add Payment");
}
static void GrupKomn()
{
    Console.WriteLine("add - Add Group");
    Console.WriteLine("update - Update group");
    Console.WriteLine("delete - delete ");
}
static void Passvord()
{
    Console.WriteLine("1 - Administrator");
    Console.WriteLine("2 - Teacher");
    Console.WriteLine("3 - Student");
}