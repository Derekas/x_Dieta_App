using Dietas_App3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dietas_App3.View
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TiposDietas : ContentPage
    {
        private TipoDietaVM dievm;
        public TiposDietas()
        {
            InitializeComponent();
            dievm = new TipoDietaVM();

            BindingContext = dievm;
        }

        private void IrHipocalorica(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HipocaloricaTabb());
        }

        private void IrMusculo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MusculoView());
        }

        private void IrMantenerse(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MantenerseView());
        }

        private void Atras(object sender, EventArgs e)
        {

        }

        private void hola(object sender, ItemTappedEventArgs e)
        {

        }
    }
}