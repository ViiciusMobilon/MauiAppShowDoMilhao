using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class MainPage : ContentPage
    {

        double premio = 1000;
        int pergunta_count = 1;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = App.getRandomPerguntaFacil();
            lbl_nivel.Text = "Fácil";
            lbl_premio.Text= premio.ToString("C");
            lbl_pergunta_numero.Text= pergunta_count.ToString();
        }

        

       
       
        void avanca_pergunta()
        {
            if (pergunta_count <= 5)
            {
                premio = premio + 1000;
                this.BindingContext = App.getRandomPerguntaFacil();
                lbl_nivel.Text = "Fácil";
            }
            if (pergunta_count > 5 && pergunta_count <= 10)
            {
                premio = premio + 10000;
                this.BindingContext = App.getRandomPerguntaMedia();
                lbl_nivel.Text = "Média";
            }
            if (pergunta_count > 10 && pergunta_count <= 15)
            {
                premio = premio + 100000;
                this.BindingContext = App.getRandomPerguntaDificil();
                lbl_nivel.Text = "Dificil";
            }
        }

        private async void Proximo_Clicked_1(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.IsChecked)
            {
                if ((bool)alt0.Value)
                {
                }
                else
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
                pergunta_count++;
                avanca_pergunta();

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
