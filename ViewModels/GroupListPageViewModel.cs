using HEADMEN_EYE.Data;
using System.Data;
using Microsoft.Data.Sqlite;
using Ultz.BeagleFramework.SQLite;

namespace HEADMEN_EYE.ViewModels
{
    public class GroupListPageViewModel : ViewModelBase
    {
        public GroupListPageViewModel()
        {
            ConnectDB dBContext = new ConnectDB();
            SqliteConnection connection = new SqliteConnection(@"Data Source=Data\HEADMEN_EYE_DB0.db");
            DataTable dt = new DataTable();
            SqliteDataAdapter sqliteDataAdapter = new SqliteDataAdapter();

            connection.Open();
            SqliteCommand command = new SqliteCommand("SELECT NameStdnt, SurnameStdnt, PatronymicStdnt, StudentGroup FROM Students", connection);
            sqliteDataAdapter.SelectCommand = command;
            sqliteDataAdapter.Fill(dt);
            dataView = dt.DefaultView;

            connection.Close();
        }

        private DataView dataView;
        public DataView Dataview
        {
            get { return dataView; }
            set { dataView = value; OnPropertyChanged(); }
        }

    }
}
