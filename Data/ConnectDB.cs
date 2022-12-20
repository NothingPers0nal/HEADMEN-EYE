using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace HEADMEN_EYE.Data
{
    public class ConnectDB : DbContext
    {
        //This function connect program with DB
        protected override void OnConfiguring(DbContextOptionsBuilder connectionWithDB)
        {
            connectionWithDB.UseSqlite("Data Source = HEADMEN_EYE_DB.db");
        }

    }
}
