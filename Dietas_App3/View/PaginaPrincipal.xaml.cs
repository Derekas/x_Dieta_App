using Dietas_App3.Helpers;
using Dietas_App3.Model;
using Dietas_App3.ViewModel;
using SQLite;
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
    public partial class PaginaPrincipal : ContentPage
    {
        
        static SQLiteAsyncConnection db = Model.DataBase.ConnectionDatabase;
        static string pickeractividad;
        static double kg,cm;
        private PaginaPrincipalVM ppvm;
        

        public PaginaPrincipal()
        {
            InitializeComponent();
            ppvm = new PaginaPrincipalVM();
            
            BindingContext = ppvm;
        }
        public InformacionEvents<UsuarioEventArgs> events = new InformacionEvents<UsuarioEventArgs>();
        private void IrTipos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TiposDietas());
        }

        private void picker(object sender, EventArgs e)
        {
            pickeractividad = Actividad.SelectedItem as String;
        }
        void SexoRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            
        }

        private void OnSliderValueChangedPeso(object sender, ValueChangedEventArgs e)
        {
           
            kg = e.NewValue;
            
            displayLabel.Text = MainSlider.Value.ToString()+ " kg";
            
        }

        private void Adddatos(object sender, EventArgs e)
        {

            
            Boolean esnuevo = ppvm.AñadirUsuario();
            if (esnuevo)
            {
                UsuarioEventArgs usu = new UsuarioEventArgs(ppvm.Usuario);
                events.TriggerHandlerAdd(usu);


            }


        }

        private void OnSliderValueChangedAltura(object sender, ValueChangedEventArgs e)
        {
            
            cm = e.NewValue;

            Altura.Text = AlturaSlider.Value.ToString()+" cm";
        }
    }
}