using Domain.Entities.Students;
using Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Groups
{
    public class Jamolar
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public string GroupDey { get; set; }
        public DateTime Created { get; set; } 
        public Teacher Teacher { get; set; }
        public virtual List<Student> Students { get; set; }
        public Jamolar()
        {
            Students = new List<Student>();
        }
    }
}
