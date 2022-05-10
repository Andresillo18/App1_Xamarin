using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BienvenidosPage : ContentPage
    {
        public BienvenidosPage()
        {
            InitializeComponent();

            //**Cuando se va a cambiar algo en XAML se debe hacer desde el constructor porque afuera es para EVENTOS**

            //Content viene de ContentPage, así se crea un Label y se hace siempre en el constructor pero SIEMPRE es mejor usar XAML
            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hola Mundo!"
            //};

            slider.Value = 0.50;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Este método viene de la herencia de ContentPage
            DisplayAlert("Título", "Hola Mundo", "Cancelar");
        }

        //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    //Cuando se mueve el slider cambia el valor del label y al moverlo genera el nuevo valor
        //    label.Text = String.Format("Número: {0:F2}", e.NewValue);
        //}
    }
}