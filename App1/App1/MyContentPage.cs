using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1
{
    public class MyContentPage : ContentPage
    {
        public MyContentPage()
        {
            //Toda la estructura de la página se construye por medio de código subyacente
            //Se inicializa a travez de las llaves y se cambian sus propiedades
            var label = new Label()
            {
                Text = "Escribe tu nombre"
            };

            //Es una view o controlar que es una caja de texto
            var txtNombre = new Entry
            {
                Placeholder = "Escribe tu nombre"
            };

            var btnPrimerBtn = new Button
            {
                Text = "Click Me!"
            };

            //Manejador de eventos 
            //Se le asigna una función flecha al evento click del botón
            //***Se debe usar obligadamente "+="
            btnPrimerBtn.Clicked += (sender, e) =>
            {
                DisplayAlert("Mensaje", txtNombre.Text,"OK");
            };

            // Como la página solo permite un contenedor se debe agrupar
            Content = new StackLayout
            {
                //Es un contenedor
                Padding = 30,
                Spacing = 10,

                //dice que tendrá adentro
                Children = {label, txtNombre, btnPrimerBtn}
            };
        }
    }
}
