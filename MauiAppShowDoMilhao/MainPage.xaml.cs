namespace MauiAppShowDoMilhao
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Proximo_Clicked(object sender, EventArgs e)
        {
            bool acertou = false;
            string resp = "";
            bool valor;

            if (alt0.Ischecked)
            {
                if ((bool)alt0.Content.ToString);
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
                DisplayAlert("ACERTOU!", resp, "OK");
                this.BindingContext = App.getRandomPerguntaFacil();

            }else
            {
                DisplayAlert("ERROU", "Você perdeu","OK".);
            }

        }
    }

}
