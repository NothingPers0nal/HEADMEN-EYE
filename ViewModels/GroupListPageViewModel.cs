using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HEADMEN_EYE.Data;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Ultz.BeagleFramework.SQLite;

namespace HEADMEN_EYE.ViewModels
{
    class GroupListPageViewModel : ViewModelBase
    {
        public GroupListPageViewModel()
        {
            ConnectDB dBContext = new ConnectDB();
            SqliteConnection connection = new SqliteConnection("Data Source=HEADMEN_EYE_DB.db");
            DataTable dt = new DataTable();
            SqliteDataAdapter sqliteDataAdapter = new SqliteDataAdapter();

            connection.Open();
            SqliteCommand command = new SqliteCommand("SELECT NameStdnt, SurnameStdnt, PatronymicStdnt, StudentGroup FROM Students", connection);
            sqliteDataAdapter.SelectCommand = command;
            sqliteDataAdapter.Fill(dt);

            
            dataView = dt.DefaultView;
            
            //System.Diagnostics.Debug.WriteLine(dt.Columns["NameStdnt"].ToString());
            connection.Close();
        }

        private DataView dataView;

        public DataView Dataview
        {
            get { return dataView; }
            set { dataView = value; OnPropertyChanged(); }
        }

        //public DataView dataView { get; private set; }

    }
}
