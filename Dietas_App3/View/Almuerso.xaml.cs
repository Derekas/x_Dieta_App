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
    public partial class Almuerso : ContentPage
    {
        

        private Comida comseleccionat;
        private AlmuVM alvm;
        public Almuerso()
        {
            InitializeComponent();
            alvm = new AlmuVM();

            BindingContext = alvm;

        }
        public InformacionEvents<ComidaEventArgs> comEvents = new InformacionEvents<ComidaEventArgs>();
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void TappeAl(object sender, ItemTappedEventArgs e)
        {
            comseleccionat = (Comida)((ListView)sender).SelectedItem;
            if (!comseleccionat.Categoria.Equals("Almuerzo"))
            {
                DisplayAlert("Item Tapped", "Porfavor seleccione un almuerzo para añadirla.", "OK");
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
                ListaComidas.ItemsSource = alvm.Comidas;
            }

            else
            {
                ListaComidas.ItemsSource = alvm.Comidas.Where(x => x.Categoria.StartsWith(e.NewTextValue));
            }
        }
    }
}
