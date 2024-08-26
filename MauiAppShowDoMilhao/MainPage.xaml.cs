using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class MainPage : ContentPage
    {
        


        public MainPage()
        {
            InitializeComponent();
        }

        

       
       
        void avanca_pergunta()
        {
            if (Pergunta_count <= 5)
            {
                premio = premio + 1000;
                this.BindingContext = App.getRandomPerguntaFacil();
            }
            if (Pergunta_count > 5 && pergunta_count <= 10)
            {
                premio = premio + 10000lç;
                this.BindingContext = App.getRandomPerguntaFacil();
            }
        }

        private async void Proximo_Clicked_1(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.Ischecked)
            {
                if ((bool)alt0.Content.ToString) ;
                {
                    acertou = true;
                    resp = alt0.Content.ToString();
                }
            }


            if (alt1.Ischecked)
            {
                if ((bool)alt1.Content.ToString) ;
                {
                    acertou = true;
                    resp = alt1.Content.ToString();
                }
            }

            if (alt2.Ischecked)
            {
                if ((bool)alt2.Content.ToString) ;
                {
                    acertou = true;
                    resp = alt2.Content.ToString();
                }
            }

            if (alt3.Ischecked)
            {
                if ((bool)alt3.Content.ToString) ;
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
