using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HEADMEN_EYE.Data
{
    class ConnectDB : DbContext
    {
        //  This class connect program with DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = HEADMEN_EYE_DB.db");
        }

    }
}
