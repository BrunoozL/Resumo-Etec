using AppGuiaDoCurso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuiaDoCurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",
                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação, selecionando linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto. • Codificar e depurar programas. ",
                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar ações que promovam a cooperação. • Desenvolver a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados II ",
                    AtribuicoesResponsabilidades = "Implementar banco de dados. ",
                    ValoresAtitudes = "Incentivar a criatividade. • Desenvolver a criticidade. • Fortalecer a persistência e o interesse na resolução de situações-problema "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile I",
                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas móveis.",
                    ValoresAtitudes = "Incentivar a criatividade. • Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a organização.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web II",
                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas de informação para web.",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar a criatividade."
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Sistemas Embarcados",
                    AtribuicoesResponsabilidades = "Criar Projetos de arduinos tanto físico quanto no TinkerCad",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar a criatividade."
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}