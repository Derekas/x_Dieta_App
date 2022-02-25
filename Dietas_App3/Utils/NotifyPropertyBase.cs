using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dietas_App3.Utils
{
    public class NotifyPropertyBase : INotifyPropertyChanged
    {
        //todos los ebentos tienen dos parametros
        //metodo para saber si se ha realizado un cambio
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
