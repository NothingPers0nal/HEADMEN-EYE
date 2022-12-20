using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace HEADMEN_EYE.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Сообщает о том, что произошли изменения.
        // Принимает название свойства, которое меняется.
        public virtual void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler.Invoke(this, new PropertyChangedEventArgs(property));
        }

        //  Сборщик мусора.
        public void Dispose()
        {
            Dispose(true);
        }

        private bool _Disposed;
        // Наследники смогут переопределить.
        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposing || _Disposed) return;
            _Disposed = true;
            // Освобождение управляемых ресурсов.
        }

    }
}
