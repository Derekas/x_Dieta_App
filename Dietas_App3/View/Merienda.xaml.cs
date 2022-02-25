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
    public partial class Merienda : ContentPage
    {
        private Comida comseleccionat;
        private MeriendaVM mvm;

        public Merienda()
        {
            InitializeComponent();
            mvm = new MeriendaVM();

            BindingContext = mvm;
        }

       
        public InformacionEvents<ComidaEventArgs> comEvents = new InformacionEvents<ComidaEventArgs>();

        
        private void MainSearchBar(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ListaComidas.ItemsSource = mvm.Comidas;
            }

            else
            {
                ListaComidas.ItemsSource = mvm.Comidas.Where(x => x.Categoria.StartsWith(e.NewTextValue));
            }
        }

        private void TappedMerienda(object sender, ItemTappedEventArgs e)
        {
            comseleccionat = (Comida)((ListView)sender).SelectedItem;
            if (!comseleccionat.Categoria.Equals("Merienda"))
            {
                DisplayAlert("Item Tapped", "Porfavor seleccione una cena para añadirla.", "OK");
            }
            else
            {
                HipocaloricaTabb v = new HipocaloricaTabb();
                ComidaEventArgs com = new ComidaEventArgs(comseleccionat);
                comEvents.TriggerHandlerAdd(com);



                Navigation.PopAsync();
            }
        }
    }
}
