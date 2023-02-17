using Domain.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Dedlines
{
    public class Dedline
    {
        public int Id { get; set; }
        public string DedlineUrl { get; set; }
        public int GroupId { get; set; }
        public string DedlineInfo { get; set; }
        public DateTime Time { get; set; } 
        public TimeSpan DedlineTime { get; set; }
    }
}
