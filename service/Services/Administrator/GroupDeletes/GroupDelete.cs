﻿using Data.O_quvMarkaziDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service.Services.Administrator.GroupDeletes
{
    public static  class GroupDelete
    {
        public static void GDelete( string GName)
        {
            AppDbContext db = new AppDbContext();
            var res = db.group.FirstOrDefault(p => p.GroupName == GName);
            db.group.Remove(res);
            db.SaveChanges();
        }
    }
}
