using Domain.Entities.Rols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Passvords
{
    public class Passvord
    {
        public int Id { get; set; }
        public int OvnId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Rol> rols { get; set; }

        public Passvord()
        {
            rols = new List<Rol>();
        }
    }
}
