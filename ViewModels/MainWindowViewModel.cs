using HEADMEN_EYE.Infrastructure;
using HEADMEN_EYE.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HEADMEN_EYE.ViewModels
{
    public class MainWindowViewModel : ViewModelBase // Показываем, что наследуется от ViewModelBase
    {
        public MainWindowViewModel()
        {
            ActivePage = new MainPageViewModel();
        }

        private ViewModelBase activePage;

        // Свойство, позволяющее получить значение переменной и установить его
        public ViewModelBase ActivePage
        {
            get { return activePage; } // Отдаёт значение из программы
            set 
            { 
                activePage = value;
                OnPropertyChanged(); // Сообщает об изменении
            }

        }

        // Свойство, создающее команду, которая меняет активную страницу и создаёт новую ViewModel
        public ICommand ChangeActivePageToGroups 
        {
            get 
            {
                return new RelayCommand((obj) => { ActivePage = new GroupListPageViewModel(); });
            }
        }

        public ICommand ChangeActivePageToPasses
        {
            get
            {
                return new RelayCommand((obj) => { ActivePage = new PassesListPageViewModel(); });
            }
        }

        public ICommand ChangeToMainPage
        {
            get
            {
                return new RelayCommand((obj) => { ActivePage = new MainPageViewModel(); });
            }
        }


    }
}
