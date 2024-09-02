using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class MainPage : ContentPage
    {

        double premio = 0;
        int pergunta_count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        

       
       
        void avanca_pergunta()
        {
            if (pergunta_count <= 5)
            {
                premio = premio + 1000;
                this.BindingContext = App.getRandomPerguntaFacil();
            }
            if (pergunta_count > 5 && pergunta_count <= 10)
            {
                premio = premio + 10000;
                this.BindingContext = App.getRandomPerguntaFacil();
            }
        }

        private async void Proximo_Clicked_1(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if ((bool) alt0.Value) 
                {
                    acertou = true;
                    resp = alt0.Content.ToString();
                }
            }


            if (alt1.IsChecked)
            {
                if ((bool) alt1.Value) 
                {
                    acertou = true;
                    resp = alt1.Content.ToString();
                }
            }

            if (alt2.IsChecked)
            {
                if ((bool) alt2.Value) 
                {
                    acertou = true;
                    resp = alt2.Content.ToString();
                }
            }

            if (alt3.IsChecked)
            {
                if ((bool) alt3.Value) 
                {
                    acertou = true;
                    resp = alt3.Content.ToString();
                }
            }
            if (acertou)
            {
                await DisplayAlert("ACERTOU!", resp, "OK");
                this.BindingContext = App.getRandomPerguntaFacil();

            }
            else
            {
                await DisplayAlert("ERROU", "Você perdeu", "OK");

            }
        }

        private void Stop_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandomPerguntaFacil();
        }
    }

}
