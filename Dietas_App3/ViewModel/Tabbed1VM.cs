using Dietas_App3.Model;
using Dietas_App3.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Dietas_App3.ViewModel
{
    public class Tabbed1VM : NotifyPropertyBase
    {
        public Comida Comida { get; set; }
        public ObservableCollection<Comida> Desayunos { get; set; }
        public ObservableCollection<Comida> Comidas { get; set; }
        public ObservableCollection<Comida> Cenas { get; set; }
        public ObservableCollection<Comida> Meriendas { get; set; }
        public ObservableCollection<Comida> Almuerso { get; set; }
        public Tabbed1VM()
        {
            Desayunos = new ObservableCollection<Comida>();
            Comidas = new ObservableCollection<Comida>();
            Cenas = new ObservableCollection<Comida>();
            Meriendas = new ObservableCollection<Comida>();
            Almuerso = new ObservableCollection<Comida>();
        }
        internal void AddDesayuno(Comida comidaseleccionada)
        {


            Boolean encontrado = false;
            foreach (Comida element in Desayunos)
            {
                if (element.id == comidaseleccionada.id)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) Desayunos.Add(comidaseleccionada);
            //Si lo quisieramos añadir a la base de datos
            //ComidaDAO.AñadirComidaAsync(Comida).Wait();
            OnPropertyChanged("Desayunos");
        }
        internal void AddComidas(Comida comidaseleccionada)
        {


            Boolean encontrado = false;
            foreach (Comida element in Comidas)
            {
                if (element.id == comidaseleccionada.id)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) Comidas.Add(comidaseleccionada);
            OnPropertyChanged("ocComidas");
        }
        internal void AddCenas(Comida comidaseleccionada)
        {


            Boolean encontrado = false;
            foreach (Comida element in Cenas)
            {
                if (element.id == comidaseleccionada.id)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) Cenas.Add(comidaseleccionada);
            OnPropertyChanged("Cenas");
        }
        internal void AddMerienda(Comida comidaseleccionada)
        {


            Boolean encontrado = false;
            foreach (Comida element in Meriendas)
            {
                if (element.id == comidaseleccionada.id)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) Meriendas.Add(comidaseleccionada);
            OnPropertyChanged("Meriendas");

        }
        internal void AddAlmuerso(Comida comidaseleccionada)
        {


            Boolean encontrado = false;
            foreach (Comida element in Almuerso)
            {
                if (element.id == comidaseleccionada.id)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) Almuerso.Add(comidaseleccionada);
            OnPropertyChanged("Almuerso");

        }
        internal void DelDesayuno(Comida comida)
        {
            Desayunos.Remove(comida);
        }
        internal void DelAlmuerso(Comida comida)
        {
            Almuerso.Remove(comida);
        }
        internal void DelComida(Comida comida)
        {
            Comidas.Remove(comida);
        }
        internal void DelMerienda(Comida comida)
        {
            Meriendas.Remove(comida);
        }
        internal void DelCena(Comida comida)
        {
            Cenas.Remove(comida);
        }
    }
}
