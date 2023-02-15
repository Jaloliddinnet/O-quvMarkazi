using Domain.Entities.Passvords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Rols
{
    public class Rol
    {
        public int Id { get; set; }
        public string RolName { get; set; }
        public Passvord Passvord { get; set; }
    }
}
