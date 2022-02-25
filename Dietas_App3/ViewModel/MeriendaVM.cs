using Dietas_App3.Model;
using Dietas_App3.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Dietas_App3.ViewModel
{
    public class MeriendaVM : NotifyPropertyBase
    {
        public Comida Comida { get; set; }
        public ObservableCollection<Comida> Comidas { get; set; }


        public MeriendaVM()
        {
            Task<List<Comida>> t = ComidaDAO.GetAllAsync();
            List<Comida> ll = t.Result;
            Comidas = new ObservableCollection<Comida>(t.Result);
            OnPropertyChanged("Comidas");


        }
    }
}
