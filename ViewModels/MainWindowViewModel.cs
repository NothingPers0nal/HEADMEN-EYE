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

        private ViewModelBase activePage;

        public ViewModelBase ActivePage
        {
            get { return activePage; }
            set 
            { 
                activePage = value;
                OnPropertyChanged();
            }

        }
        


        public ICommand ChangeActivePage 
        {
            get 
            {
                return new RelayCommand((obj) => { ActivePage = new GroupListPageViewModel(); });
            }
        }

    }
}
