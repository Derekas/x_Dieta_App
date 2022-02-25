using Dietas_App3.Helpers;
using Dietas_App3.Model;
using Dietas_App3.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dietas_App3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Desayuno : ContentPage
    {
        String nom;
        private Comida comseleccionat;
        private DesayunoVM dvm;
        
        public Desayuno()
        {
            InitializeComponent();
            dvm = new DesayunoVM();
            
            BindingContext = dvm;
            
        }
        public InformacionEvents<ComidaEventArgs> comEvents = new InformacionEvents<ComidaEventArgs>();


        void TappedDesayuno(object sender, ItemTappedEventArgs e)
        {
            comseleccionat = (Comida)((ListView)sender).SelectedItem;
            if (!comseleccionat.Categoria.Equals("Desayuno"))
            {
                DisplayAlert("Item Tapped", "Porfavor seleccione un desayuno para añadirlo.", "OK");
            }
            else
            {
                HipocaloricaTabb v = new HipocaloricaTabb();
                ComidaEventArgs com = new ComidaEventArgs(comseleccionat);
                comEvents.TriggerHandlerAdd(com);
                
                

                Navigation.PopAsync();
            }
            

        }
        void OnBtnPressed(object sender, TextChangedEventArgs e)
        {
            
            
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ListaComidas.ItemsSource = dvm.Comidas;
            }

            else
            {
                ListaComidas.ItemsSource = dvm.Comidas.Where(x => x.Nom.StartsWith(e.NewTextValue));
            }
        }

        private void MainSearchBar(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ListaComidas.ItemsSource = dvm.Comidas;
            }

            else
            {
                ListaComidas.ItemsSource = dvm.Comidas.Where(x => x.Categoria.StartsWith(e.NewTextValue));
            }
        }
        
    }
}
