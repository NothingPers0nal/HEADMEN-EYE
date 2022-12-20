using System;
using System.Windows.Input;

namespace HEADMEN_EYE.Infrastructure
{
    public class RelayCommand : ICommand
    {
        // Действие, которое принимает объект
        private Action<object> execute;
        private Predicate<object> canExecute;

        // Событие, которое позволяет переключать состояние кнопки
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        // Создаём команду и инициализируем событие
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        // Проверяем, может ли выполняться
        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute.Invoke(parameter);
        }

        // Выполняет
        public void Execute(object parameter)
        {
            execute.Invoke(parameter);
        }
    }
}
