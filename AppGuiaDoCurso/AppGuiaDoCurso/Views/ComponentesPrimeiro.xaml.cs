using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppGuiaDoCurso.Models;
namespace AppGuiaDoCurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Fundamentos da Informática",
                    AtribuicoesResponsabilidades = "História da tecnologia e sua evolução até onde chegamos hoje em dia.",
                    ValoresAtitudes = "Estimular conhecimentos do que poderá chegar no futuro. • Incentivar comportamentos éticos"
                    + ". • Desenvolver a criticidade."
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
                    Nome = "Porgramação e Algoritmos",
                    AtribuicoesResponsabilidades = "Implementar algoritmos em linguagem de programação utilizando " +
                    "ambientes de desenvolvimento de acordo com as necessidades.",
                    ValoresAtitudes = "Estimular a organização. • Incentivar atitudes de autonomia. • Fortalecer a persistência " +
                    "e o interesse do aluno na resolução de problemas."
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
                    Nome = "Banco de Dados I",
                    AtribuicoesResponsabilidades = "Modelar banco de dados.",
                    ValoresAtitudes = "Estimular a organização de infromações tanto suas qaunto pessoais" +
                    ". • Fortalecer a persistência e o interesse na resolução."
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
                    Nome = "Análise e Projeto de Sistemas",
                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação.  ",
                    ValoresAtitudes = "Estimular a organização. • Incentivar a criatividade. Fortalecer a" +
                    " persistência e o interesse na resolução de situações-problema."
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
                    Nome = "Design Digital",
                    AtribuicoesResponsabilidades = "Desenvolver elementos gráficos para aplicativos e sites.",
                    ValoresAtitudes = "Incentivar a criatividade. • Respeitar as manifestações culturais de outros povos. • " +
                    "Incentivar ações que promovam a cooperação. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web I",
                    AtribuicoesResponsabilidades = "Desenvolver sites para Web ",
                    ValoresAtitudes = "Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }

            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }


        private async void Button_Clicked_7(object sender, EventArgs e)
        {

            {
                try
                {
                    var c = new Componente
                    {
                        Nome = "Técnicas de Programação",
                        AtribuicoesResponsabilidades = "Desenvolver programas de computador, utilizando princípios de boas práticas. Realizar versionamento no desenvolvimento de programas.  • Verificar usabilidade no desenvolvimento de programas.",
                        ValoresAtitudes = "Incentivar a criatividade. • Incentivar comportamentos éticos. • Fortalecer a persistência e o interesse na resolução de situações-problema. "
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
}