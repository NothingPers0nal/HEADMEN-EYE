using System;
using System.Windows;
using System.Windows.Controls;
using HEADMEN_EYE.Data;
using HEADMEN_EYE.ViewModels;
using Microsoft.Data.Sqlite;

namespace HEADMEN_EYE.View
{
    /// <summary>
    /// Логика взаимодействия для AttendancePage.xaml
    /// </summary>
    public partial class AttendancePage : Page
    {
        public AttendancePage()
        {
            InitializeComponent();
        }

        private void btnSetPasses_Click(object sender, RoutedEventArgs e)
        {
            SqliteConnection connection = new SqliteConnection(@"Data Source=Data\HEADMEN_EYE_DB0.db");
            connection.Open();

            string nameStdnt = nameComboBox.Text.ToString();
            string surnameStdnt = surnameComboBox.Text.ToString();
            string group = groupsComboBox.Text.ToString();
            int hours = 0;

            if (int.TryParse(hoursTextBox.Text, out hours))
            {
                SqliteCommand passesCommand = new SqliteCommand();
                passesCommand.Connection = connection;
                passesCommand.CommandText = $"UPDATE Students SET Passes = Passes + {hours} WHERE NameStdnt = '{surnameStdnt}' AND SurnameStdnt = '{nameStdnt}' AND StudentGroup = '{group}'";
                int number = passesCommand.ExecuteNonQuery();
                
            }
            else
            {
                MessageBox.Show("Количество пропущенных часов должно быть цифрой!", "ValueError");
            }

            connection.Close();
        }
    }
}
