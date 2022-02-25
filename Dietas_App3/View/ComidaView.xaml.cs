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
    public partial class ComidaView : ContentPage
    {
        String nom;
        private Comida comseleccionat;
        private ComidasVM cvm;

        public ComidaView()
        {
            InitializeComponent();
            cvm = new ComidasVM();

            BindingContext = cvm;
        }

        
        private void MainSearchBar(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ListaComidas.ItemsSource = cvm.Comidas;
            }

            else
            {
                ListaComidas.ItemsSource = cvm.Comidas.Where(x => x.Categoria.StartsWith(e.NewTextValue));
            }
        }
        public InformacionEvents<ComidaEventArgs> comEvents = new InformacionEvents<ComidaEventArgs>();

        private void TappeComida(object sender, ItemTappedEventArgs e)
        {
            comseleccionat = (Comida)((ListView)sender).SelectedItem;
            if (!comseleccionat.Categoria.Equals("Comida"))
            {
                DisplayAlert("Item Tapped", "Porfavor seleccione una comida para añadirlo.", "OK");
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
