using System;
using HEADMEN_EYE.Data;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Collections.ObjectModel;


namespace HEADMEN_EYE.ViewModels
{
    class AttendancePageViewModel : ViewModelBase
    {
        public ObservableCollection<string> CollectionSurname { get; set; } = new();
        public ObservableCollection<string> CollectionName { get; set; } = new();
        public ObservableCollection<string> CollectionGroups { get; set; } = new();

        public AttendancePageViewModel()
        {
            ConnectDB dBContext = new ConnectDB();
            SqliteConnection connection = new SqliteConnection(@"Data Source=Data\HEADMEN_EYE_DB0.db");

            connection.Open();
            SqliteCommand commandSurname = new SqliteCommand("SELECT NameStdnt FROM Students", connection);
            SqliteCommand commandName = new SqliteCommand("SELECT SurnameStdnt FROM Students", connection);
            SqliteCommand commandGroups = new SqliteCommand("SELECT StudentGroup FROM StudentGroups", connection);

            SqliteDataReader drSurname = commandSurname.ExecuteReader();
            SqliteDataReader drName = commandName.ExecuteReader();
            SqliteDataReader drGroups = commandGroups.ExecuteReader();

            while (drSurname.Read())
            {
                CollectionSurname.Add((string)drSurname[0]);
            }

            while (drName.Read())
            {
                CollectionName.Add((string)drName[0]);
            }

            while (drGroups.Read())
            {
                CollectionGroups.Add((string)drGroups[0]);
            }
            connection.Close();
        }

        private DataView dataView;
        public DataView DataView
        {
            get { return dataView; }
            set { dataView = value; OnPropertyChanged(); }
        }

    }
}
