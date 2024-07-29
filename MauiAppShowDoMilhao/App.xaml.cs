using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {

        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id= 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="LÍQUIDA"},
                    new Alternativa{ Correta = true, Descricao ="SÓLIDO"},
                    new Alternativa{ Correta = false, Descricao ="GASOSO"},
                    new Alternativa{ Correta = false, Descricao ="VAPOROSO"},


                }



            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
