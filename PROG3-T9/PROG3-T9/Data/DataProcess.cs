using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROG3_T9.Data
{
    public class DataProcess
    {
        DataContext db = new DataContext();
        public void Save(Request obj)
        {
            db.Database.EnsureCreated();
            db.Requests.Add(obj);
            db.SaveChanges();
        }
    }
}
