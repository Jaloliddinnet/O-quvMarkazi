using Domain.Entities.Students;
using Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Chat
{
    public class ChatTeachStud
    {
        public int Id { get; set; }
        public string Chat { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
    }
}
