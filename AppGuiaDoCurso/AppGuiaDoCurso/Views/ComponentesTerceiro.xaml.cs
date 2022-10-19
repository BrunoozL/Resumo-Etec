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
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados III",
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

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile II",
                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para plataformas móveis",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Incentivar a criatividade. • " +
                    "Estimular a organização"
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
                    Nome = "Programação Web III",
                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para web",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Incentivar a criatividade" +
                    ". • Estimular a organização"
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
                    Nome = "Qualidade e Teste de Software",
                    AtribuicoesResponsabilidades = "Testar softwares para melhoria da qualidade de sistemas",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a proatividade. • " +
                    "Desenvolver criticidade"
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
                    Nome = "Internet e Protocolos",
                    AtribuicoesResponsabilidades = "Utilizar protocolos de redes e internet para comunicação de dados",
                    ValoresAtitudes = "Incentivar comportamentos éticos. • Promover ações que considerem o respeito às normas estabelecidas" +
                    ". • Fortalecer a persistência e o interesse na resolução de situações-problema"
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
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas",
                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais",
                    ValoresAtitudes = "Planejar ações mais eficazes no desenvolvimento de sistemas. • Demonstra comprometimento com equipe e o trabalho"
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