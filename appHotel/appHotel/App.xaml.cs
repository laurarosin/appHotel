using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using appHotel.View;
using appHotel.Model;

namespace appHotel
{
    public partial class App : Application
    {

        public List<Suite> Suites = new List<Suite>()
        {
            new Suite()
            {
                Descricao = "Super Luxo",
                ValorDiariaAdulto = 95.5,
                ValorDiariaCrianca = 45.5
            },

            new Suite()
            {
                Descricao = "Luxo",
                ValorDiariaAdulto = 80,
                ValorDiariaCrianca = 40
            },

            new Suite()
            {
                Descricao = "Pobre Premium (classe média)",
                ValorDiariaAdulto = 70.5,
                ValorDiariaCrianca = 35.5
            }
        };


        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            MainPage = new NavigationPage(new View.ContratacaoHosp());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
