using System;
using HEADMEN_EYE.Data;
using System.Data;
using Microsoft.Data.Sqlite;
using Ultz.BeagleFramework.SQLite;
using HEADMEN_EYE.View;
using System.Collections.ObjectModel;

namespace HEADMEN_EYE.ViewModels
{
    class AttendancePageViewModel : ViewModelBase
    {
        public AttendancePageViewModel()
        {
            //ConnectDB dBContext = new ConnectDB();
            //SqliteConnection connection = new SqliteConnection(@"Data Source=Data\HEADMEN_EYE_DB0.db");
            //DataSet ds = new DataSet();
            //SqliteDataAdapter sqliteDataAdapter = new SqliteDataAdapter();

            //connection.Open();
            //SqliteCommand commandSurname = new SqliteCommand("SELECT SurnameStdnt FROM Students", connection);
            //sqliteDataAdapter.SelectCommand = commandSurname;

            //SqliteDataReader dr = commandSurname.ExecuteReader();

            //System.Object[] ItemObject = new System.Object[0];
            //while (dr.Read())
            //{
            //    dataView = (DataView?)dr[0];
            //}
        }

        private DataView dataView;
        public DataView Dataview
        {
            get { return dataView; }
            set { dataView = value; OnPropertyChanged(); }
        }
    }
}
