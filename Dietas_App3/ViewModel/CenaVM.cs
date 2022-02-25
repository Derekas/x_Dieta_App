using Dietas_App3.Model;
using Dietas_App3.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Dietas_App3.ViewModel
{
    public class CenaVM : NotifyPropertyBase
    {
        public Comida Comida { get; set; }
        public ObservableCollection<Comida> Comidas { get; set; }


        public CenaVM()
        {
            //cogemos todas las comidas y las añadimos a la lista Comidas
            Task<List<Comida>> t = ComidaDAO.GetAllAsync();
            List<Comida> ll = t.Result;
            Comidas = new ObservableCollection<Comida>(t.Result);
            OnPropertyChanged("Comidas");


        }
    }
}
