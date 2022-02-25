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
    public partial class Cena : ContentPage
    {
        String nom;
        private Comida comseleccionat;
        private CenaVM cevm;
        public Cena()
        {
            InitializeComponent();
            cevm = new CenaVM();

            BindingContext = cevm;
        }

        public InformacionEvents<ComidaEventArgs> comEvents = new InformacionEvents<ComidaEventArgs>();

        private void TappeCena(object sender, ItemTappedEventArgs e)
        {
            comseleccionat = (Comida)((ListView)sender).SelectedItem;
            if (!comseleccionat.Categoria.Equals("Cena"))
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
        private void MainSearchBar(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ListaComidas.ItemsSource = cevm.Comidas;
            }

            else
            {
                ListaComidas.ItemsSource = cevm.Comidas.Where(x => x.Categoria.StartsWith(e.NewTextValue));
            }
        }
    }
}
