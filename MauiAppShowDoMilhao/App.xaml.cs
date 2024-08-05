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


                },



            },

             new Pergunta
            {
                Id= 2,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="MARGARIDA"},
                    new Alternativa{ Correta = true, Descricao ="MINNIE"},
                    new Alternativa{ Correta = false, Descricao ="A PEQUENA SEREIA"},
                    new Alternativa{ Correta = false, Descricao ="OLÍVIA PALITO"},


                },



            },

             new Pergunta
            {
                Id= 3,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="CUCA"},
                    new Alternativa{ Correta = true, Descricao ="NEGRINHO DO PASTOREIO"},
                    new Alternativa{ Correta = false, Descricao ="BOITATÁ"},
                    new Alternativa{ Correta = false, Descricao ="SACI-PERERÊ"},
                },
            },

               new Pergunta
            {
                Id= 4,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="DUQUE DE CAXIAS"},
                    new Alternativa{ Correta = true, Descricao ="MARECHAL RONDON"},
                    new Alternativa{ Correta = false, Descricao ="DOM PEDRO II"},
                    new Alternativa{ Correta = false, Descricao ="MARECHAL DEODORO"},
                },
            },

                new Pergunta
            {
                Id= 5,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="RAUL GIL"},
                    new Alternativa{ Correta = true, Descricao ="BOLINHA"},
                    new Alternativa{ Correta = false, Descricao ="FLÁVIO CAVALCANTI"},
                    new Alternativa{ Correta = false, Descricao ="CHACRINHA"},
                },
            },

                new Pergunta
            {
                Id= 6,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="MONSTRO"},
                    new Alternativa{ Correta = true, Descricao ="GORILA"},
                    new Alternativa{ Correta = false, Descricao ="PRÍNCIPE"},
                    new Alternativa{ Correta = false, Descricao ="SAPO"},
                },
            },
                new Pergunta
            {
                Id= 7,
                Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="VIRGEM"},
                    new Alternativa{ Correta = true, Descricao ="AQUÁRIO"},
                    new Alternativa{ Correta = false, Descricao ="CAPRICÓRNIO"},
                    new Alternativa{ Correta = false, Descricao ="ÁRIES"},
                },
            },

                new Pergunta
            {
                Id= 8,
                Enunciado = "Qual é a cor que se associacom os grupos ecológicos?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="PRETA"},
                    new Alternativa{ Correta = true, Descricao ="VERMELHA"},
                    new Alternativa{ Correta = false, Descricao ="AZUL"},
                    new Alternativa{ Correta = false, Descricao ="VERDE"},
                },
            },

                 new Pergunta
            {
                Id= 9,
                Enunciado = "A água ferve a quantos graus centígrados?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="200"},
                    new Alternativa{ Correta = true, Descricao ="100"},
                    new Alternativa{ Correta = false, Descricao ="170"},
                    new Alternativa{ Correta = false, Descricao ="220"},
                },
            },

                 new Pergunta
            {
                Id= 10,
                Enunciado = "Quem tem por lema a frase:“Sempre alerta”?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="MÉDICOS"},
                    new Alternativa{ Correta = true, Descricao ="ESCOTEIROS"},
                    new Alternativa{ Correta = false, Descricao ="BOMBEIROS"},
                    new Alternativa{ Correta = false, Descricao ="POLICIAIS"},
                },
            },

                 new Pergunta
            {
                Id= 12,
                Enunciado = "Quem foi o grande amor de Julieta?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="ROMEU"},
                    new Alternativa{ Correta = true, Descricao ="ORFEU"},
                    new Alternativa{ Correta = false, Descricao ="HAMLET"},
                    new Alternativa{ Correta = false, Descricao ="IAGO"},
                },
            },

                  new Pergunta
            {
                Id= 13,
                Enunciado = "Quantos signos formam o zodíaco?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="NOVE"},
                    new Alternativa{ Correta = true, Descricao ="DEZ"},
                    new Alternativa{ Correta = false, Descricao ="ONZE"},
                    new Alternativa{ Correta = false, Descricao ="DOZE"},
                },
            },

                  new Pergunta
            {
                Id= 14,
                Enunciado = "Vatapá é uma comida típica de qual estado?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="PARANÁ"},
                    new Alternativa{ Correta = true, Descricao ="SANTA CATARINA"},
                    new Alternativa{ Correta = false, Descricao ="SÃO PAULO"},
                    new Alternativa{ Correta = false, Descricao ="BAHIA"},
                },
            },

                   new Pergunta
            {
                Id= 14,
                Enunciado = "Como se chama o lugar onde são armazenadas as balas deum revólver?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao ="CANO"},
                    new Alternativa{ Correta = true, Descricao ="TAMBOR"},
                    new Alternativa{ Correta = false, Descricao ="AGULHA"},
                    new Alternativa{ Correta = false, Descricao ="GATILHO"},
                },
            },



        };
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
