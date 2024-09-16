using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        
      static List<Pergunta> perguntas_faceis = new()
{ 
    new Pergunta
    {
        Id = 1,
        Enunciado = "Qual é o maior planeta do Sistema Solar?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Terra" },
            new Alternativa { Correta = false, Descricao = "Marte" },
            new Alternativa { Correta = false, Descricao = "Vênus" },
            new Alternativa { Correta = true, Descricao = "Júpiter" }
        }
    },
    new Pergunta
    {
        Id = 2,
        Enunciado = "Qual é a capital da França?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Londres" },
            new Alternativa { Correta = false, Descricao = "Berlim" },
            new Alternativa { Correta = false, Descricao = "Madri" },
            new Alternativa { Correta = true, Descricao = "Paris" }
        }
    },
    new Pergunta
    {
        Id = 3,
        Enunciado = "Qual é o elemento químico com símbolo O?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Ouro" },
            new Alternativa { Correta = false, Descricao = "Osmium" },
            new Alternativa { Correta = false, Descricao = "Oxigênio" },
            new Alternativa { Correta = true, Descricao = "Oxigênio" }
        }
    },
    new Pergunta
    {
        Id = 4,
        Enunciado = "Qual é a cor do céu em um dia claro?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Verde" },
            new Alternativa { Correta = false, Descricao = "Vermelho" },
            new Alternativa { Correta = false, Descricao = "Amarelo" },
            new Alternativa { Correta = true, Descricao = "Azul" }
        }
    },
    new Pergunta
    {
        Id = 5,
        Enunciado = "Quantos estados tem o Brasil?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "24" },
            new Alternativa { Correta = false, Descricao = "26" },
            new Alternativa { Correta = false, Descricao = "27" },
            new Alternativa { Correta = true, Descricao = "26" }
        }
    },
    new Pergunta
    {
        Id = 6,
        Enunciado = "Qual é o nome do famoso rato da Disney?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Pato Donald" },
            new Alternativa { Correta = false, Descricao = "Goofy" },
            new Alternativa { Correta = false, Descricao = "Tom" },
            new Alternativa { Correta = true, Descricao = "Mickey Mouse" }
        }
    },
    new Pergunta
    {
        Id = 7,
        Enunciado = "Qual é o maior oceano da Terra?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Oceano Atlântico" },
            new Alternativa { Correta = false, Descricao = "Oceano Índico" },
            new Alternativa { Correta = false, Descricao = "Oceano Ártico" },
            new Alternativa { Correta = true, Descricao = "Oceano Pacífico" }
        }
    },
    new Pergunta
    {
        Id = 8,
        Enunciado = "Quem escreveu 'Dom Quixote'?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Jorge Luis Borges" },
            new Alternativa { Correta = false, Descricao = "Gabriel García Márquez" },
            new Alternativa { Correta = false, Descricao = "Miguel de Cervantes" },
            new Alternativa { Correta = true, Descricao = "Miguel de Cervantes" }
        }
    },
    new Pergunta
    {
        Id = 9,
        Enunciado = "Qual é a moeda oficial dos Estados Unidos?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Euro" },
            new Alternativa { Correta = false, Descricao = "Real" },
            new Alternativa { Correta = false, Descricao = "Libra" },
            new Alternativa { Correta = true, Descricao = "Dólar" }
        }
    },
    new Pergunta
    {
        Id = 10,
        Enunciado = "Qual é o planeta mais próximo do Sol?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Vênus" },
            new Alternativa { Correta = false, Descricao = "Terra" },
            new Alternativa { Correta = false, Descricao = "Marte" },
            new Alternativa { Correta = true, Descricao = "Mercúrio" }
        }
    },
    new Pergunta
    {
        Id = 11,
        Enunciado = "Qual é o nome do livro sagrado do Islã?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Torá" },
            new Alternativa { Correta = false, Descricao = "Bíblia" },
            new Alternativa { Correta = false, Descricao = "Vedas" },
            new Alternativa { Correta = true, Descricao = "Alcorão" }
        }
    },
    new Pergunta
    {
        Id = 12,
        Enunciado = "Qual é o nome do continente onde está localizado o Egito?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Ásia" },
            new Alternativa { Correta = false, Descricao = "América" },
            new Alternativa { Correta = false, Descricao = "Oceania" },
            new Alternativa { Correta = true, Descricao = "África" }
        }
    },
    new Pergunta
    {
        Id = 13,
        Enunciado = "Qual é o principal gás que compõe a atmosfera terrestre?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Dióxido de carbono" },
            new Alternativa { Correta = false, Descricao = "Neônio" },
            new Alternativa { Correta = false, Descricao = "Argônio" },
            new Alternativa { Correta = true, Descricao = "Nitrogênio" }
        }
    },
    new Pergunta
    {
        Id = 14,
        Enunciado = "Qual é o nome do cientista que desenvolveu a teoria da evolução por seleção natural?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Louis Pasteur" },
            new Alternativa { Correta = false, Descricao = "Gregor Mendel" },
            new Alternativa { Correta = false, Descricao = "Charles Darwin" },
            new Alternativa { Correta = true, Descricao = "Charles Darwin" }
        }
    },
    new Pergunta
    {
        Id = 15,
        Enunciado = "Quantos continentes existem na Terra?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "5" },
            new Alternativa { Correta = false, Descricao = "6" },
            new Alternativa { Correta = false, Descricao = "7" },
            new Alternativa { Correta = true, Descricao = "7" }
        }
    },
    new Pergunta
    {
        Id = 16,
        Enunciado = "Qual é o nome da capital do Brasil?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "São Paulo" },
            new Alternativa { Correta = false, Descricao = "Rio de Janeiro" },
            new Alternativa { Correta = false, Descricao = "Salvador" },
            new Alternativa { Correta = true, Descricao = "Brasília" }
        }
    },
    new Pergunta
    {
        Id = 17,
        Enunciado = "Qual é o nome da maior espécie de tubarão?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Tubarão Branco" },
            new Alternativa { Correta = false, Descricao = "Tubarão Azul" },
            new Alternativa { Correta = false, Descricao = "Tubarão Martelo" },
            new Alternativa { Correta = true, Descricao = "Tubarão-Baleia" }
        }
    },
   new Pergunta
    {
        Id = 18,
        Enunciado = "Quem pintou a Mona Lisa?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Vincent van Gogh" },
            new Alternativa { Correta = false, Descricao = "Claude Monet" },
            new Alternativa { Correta = false, Descricao = "Pablo Picasso" },
            new Alternativa { Correta = true, Descricao = "Leonardo da Vinci" }
        }
    },
    new Pergunta
    {
        Id = 19,
        Enunciado = "Qual é o nome do astro-rei do nosso sistema solar?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Lua" },
            new Alternativa { Correta = false, Descricao = "Júpiter" },
            new Alternativa { Correta = false, Descricao = "Marte" },
            new Alternativa { Correta = true, Descricao = "Sol" }
        }
    },
    new Pergunta
    {
        Id = 20,
        Enunciado = "Qual é o nome do maior deserto do mundo?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Deserto do Saara" },
            new Alternativa { Correta = false, Descricao = "Deserto de Gobi" },
            new Alternativa { Correta = false, Descricao = "Deserto da Arábia" },
            new Alternativa { Correta = true, Descricao = "Deserto Antártico" }
        }
    }
};
        

        static List<Pergunta> perguntas_medianas = new()
{
    new Pergunta
    {
        Id = 1,
        Enunciado = "Qual é o nome do processo pelo qual as plantas produzem seu próprio alimento?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Respiração" },
            new Alternativa { Correta = false, Descricao = "Digestão" },
            new Alternativa { Correta = false, Descricao = "Fermentação" },
            new Alternativa { Correta = true, Descricao = "Fotossíntese" }
        }
    },
    new Pergunta
    {
        Id = 2,
        Enunciado = "Qual é o país com a maior população do mundo?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Índia" },
            new Alternativa { Correta = false, Descricao = "Estados Unidos" },
            new Alternativa { Correta = false, Descricao = "Indonésia" },
            new Alternativa { Correta = true, Descricao = "China" }
        }
    },
    new Pergunta
    {
        Id = 3,
        Enunciado = "Qual é o elemento químico com símbolo Fe?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Ferro" },
            new Alternativa { Correta = false, Descricao = "Flúor" },
            new Alternativa { Correta = false, Descricao = "Fermio" },
            new Alternativa { Correta = true, Descricao = "Ferro" }
        }
    },
    new Pergunta
    {
        Id = 4,
        Enunciado = "Quem foi o presidente dos Estados Unidos durante a Segunda Guerra Mundial?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Abraham Lincoln" },
            new Alternativa { Correta = false, Descricao = "John F. Kennedy" },
            new Alternativa { Correta = false, Descricao = "Theodore Roosevelt" },
            new Alternativa { Correta = true, Descricao = "Franklin D. Roosevelt" }
        }
    },
    new Pergunta
    {
        Id = 5,
        Enunciado = "Qual é o maior rio do mundo em volume de água?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Rio Nilo" },
            new Alternativa { Correta = false, Descricao = "Rio Amazonas" },
            new Alternativa { Correta = false, Descricao = "Rio Yangtze" },
            new Alternativa { Correta = true, Descricao = "Rio Amazonas" }
        }
    },
    new Pergunta
    {
        Id = 6,
        Enunciado = "Qual é o principal componente do ar atmosférico?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Dióxido de carbono" },
            new Alternativa { Correta = false, Descricao = "Oxigênio" },
            new Alternativa { Correta = false, Descricao = "Argônio" },
            new Alternativa { Correta = true, Descricao = "Nitrogênio" }
        }
    },
    new Pergunta
    {
        Id = 7,
        Enunciado = "Qual é a unidade de medida da intensidade de corrente elétrica?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Volt" },
            new Alternativa { Correta = false, Descricao = "Ohm" },
            new Alternativa { Correta = false, Descricao = "Joule" },
            new Alternativa { Correta = true, Descricao = "Ampere" }
        }
    },
    new Pergunta
    {
        Id = 8,
        Enunciado = "Qual é o nome do primeiro satélite artificial lançado ao espaço?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Apollo 11" },
            new Alternativa { Correta = false, Descricao = "Vostok 1" },
            new Alternativa { Correta = false, Descricao = "Hubble" },
            new Alternativa { Correta = true, Descricao = "Sputnik 1" }
        }
    },
    new Pergunta
    {
        Id = 9,
        Enunciado = "Qual é o nome do autor do livro '1984'?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Aldous Huxley" },
            new Alternativa { Correta = false, Descricao = "Ray Bradbury" },
            new Alternativa { Correta = false, Descricao = "F. Scott Fitzgerald" },
            new Alternativa { Correta = true, Descricao = "George Orwell" }
        }
    },
    new Pergunta
    {
        Id = 10,
        Enunciado = "Qual é a capital do Japão?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Seul" },
            new Alternativa { Correta = false, Descricao = "Pequim" },
            new Alternativa { Correta = false, Descricao = "Bangkok" },
            new Alternativa { Correta = true, Descricao = "Tóquio" }
        }
    },
    new Pergunta
    {
        Id = 11,
        Enunciado = "Qual é a língua oficial do Brasil?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Espanhol" },
            new Alternativa { Correta = false, Descricao = "Inglês" },
            new Alternativa { Correta = false, Descricao = "Francês" },
            new Alternativa { Correta = true, Descricao = "Português" }
        }
    },
    new Pergunta
    {
        Id = 12,
        Enunciado = "Qual é o nome do processo de conversão de um líquido em gás?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Solidificação" },
            new Alternativa { Correta = false, Descricao = "Condensação" },
            new Alternativa { Correta = false, Descricao = "Fusão" },
            new Alternativa { Correta = true, Descricao = "Evaporação" }
        }
    },
    new Pergunta
    {
        Id = 13,
        Enunciado = "Qual é o nome do planeta conhecido como 'Planeta Vermelho'?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Júpiter" },
            new Alternativa { Correta = false, Descricao = "Saturno" },
            new Alternativa { Correta = false, Descricao = "Urano" },
            new Alternativa { Correta = true, Descricao = "Marte" }
        }
    },
    new Pergunta
    {
        Id = 14,
        Enunciado = "Qual é o nome do famoso físico que desenvolveu a teoria da relatividade?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Niels Bohr" },
            new Alternativa { Correta = false, Descricao = "Isaac Newton" },
            new Alternativa { Correta = false, Descricao = "Galileu Galilei" },
            new Alternativa { Correta = true, Descricao = "Albert Einstein" }
        }
    },
    new Pergunta
    {
        Id = 15,
        Enunciado = "Qual é o nome da teoria que descreve a formação e evolução do universo a partir de um estado extremamente quente e denso?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Teoria da Evolução" },
            new Alternativa { Correta = false, Descricao = "Teoria do Big Crunch" },
            new Alternativa { Correta = false, Descricao = "Teoria da Relatividade" },
            new Alternativa { Correta = true, Descricao = "Teoria do Big Bang" }
        }
    },
    new Pergunta
    {
        Id = 16,
        Enunciado = "Qual é o nome do processo pelo qual as plantas e animais convertem alimento em energia?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Fotossíntese" },
            new Alternativa { Correta = false, Descricao = "Condensação" },
            new Alternativa { Correta = false, Descricao = "Evaporação" },
            new Alternativa { Correta = true, Descricao = "Respiração celular" }
        }
    },
    new Pergunta
    {
        Id = 17,
        Enunciado = "Qual é a obra do autor brasileiro Machado de Assis que se passa no Rio de Janeiro do século XIX?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Dom Casmurro" },
            new Alternativa { Correta = false, Descricao = "Memórias Póstumas de Brás Cubas" },
            new Alternativa { Correta = false, Descricao = "O Primo Basílio" },
            new Alternativa { Correta = true, Descricao = "Memórias Póstumas de Brás Cubas" }
        }
    },
    new Pergunta
    {
        Id = 18,
        Enunciado = "Qual é o nome do fenômeno meteorológico que causa chuvas fortes e ventos intensos em uma região?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Tornado" },
            new Alternativa { Correta = false, Descricao = "Nevasca" },
            new Alternativa { Correta = false, Descricao = "Ciclone" },
            new Alternativa { Correta = true, Descricao = "Furacão" }
        }
    },
    new Pergunta
    {
        Id = 19,
        Enunciado = "Qual é o nome do presidente brasileiro que governou durante a Constituição de 1988?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Fernando Henrique Cardoso" },
            new Alternativa { Correta = false, Descricao = "Jair Bolsonaro" },
            new Alternativa { Correta = false, Descricao = "Itamar Franco" },
            new Alternativa { Correta = true, Descricao = "José Sarney" }
        }
    },
    new Pergunta
    {
        Id = 20,
        Enunciado = "Qual é o nome da figura mitológica grega conhecida por transformar tudo o que tocava em ouro?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Hércules" },
            new Alternativa { Correta = false, Descricao = "Perseu" },
            new Alternativa { Correta = false, Descricao = "Ulisses" },
            new Alternativa { Correta = true, Descricao = "Midas" }
        }
    }
};
       

        static List<Pergunta> perguntas_dificeis = new()
{
    new Pergunta
    {
        Id = 1,
        Enunciado = "Qual é a solução matemática para a equação de Navier-Stokes em dimensões tridimensionais?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Equação de Schrödinger" },
            new Alternativa { Correta = false, Descricao = "Teorema de Pythagoras" },
            new Alternativa { Correta = false, Descricao = "Teorema de Fermat" },
            new Alternativa { Correta = true, Descricao = "Não há uma solução geral conhecida" }
        }
    },
    new Pergunta
    {
        Id = 2,
        Enunciado = "Qual é o nome do paradoxo que descreve a situação em que uma partícula pode estar em dois lugares ao mesmo tempo?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Paradoxo de Zeno" },
            new Alternativa { Correta = true, Descricao = "Paradoxo da Superposição" },
            new Alternativa { Correta = false, Descricao = "Paradoxo de Fermi" },
            new Alternativa { Correta = false, Descricao = "Paradoxo de Olbers" }
        }
    },
    new Pergunta
    {
        Id = 3,
        Enunciado = "Qual é a obra seminal que introduziu a ideia de 'evolução por seleção natural'?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "A Origem das Espécies" },
            new Alternativa { Correta = false, Descricao = "A Descida do Homem" },
            new Alternativa { Correta = false, Descricao = "O Gene Egoísta" },
            new Alternativa { Correta = true, Descricao = "Sobre a Origem das Espécies" }
        }
    },
    new Pergunta
    {
        Id = 4,
        Enunciado = "Qual é o nome do teorema que afirma que em um triângulo qualquer, a soma dos ângulos internos é sempre 180 graus?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Teorema de Euler" },
            new Alternativa { Correta = false, Descricao = "Teorema de Pythagoras" },
            new Alternativa { Correta = false, Descricao = "Teorema de Fermat" },
            new Alternativa { Correta = true, Descricao = "Teorema da Soma dos Ângulos Internos" }
        }
    },
    new Pergunta
    {
        Id = 5,
        Enunciado = "Quem formulou a teoria da relatividade restrita?",
        Alternativas = new()
        {
            new Alternativa { Correta = true, Descricao = "Albert Einstein" },
            new Alternativa { Correta = false, Descricao = "Isaac Newton" },
            new Alternativa { Correta = false, Descricao = "Galileu Galilei" },
            new Alternativa { Correta = false, Descricao = "Niels Bohr" }
        }
    },
    new Pergunta
    {
        Id = 6,
        Enunciado = "Qual é o nome do matemático francês que provou o Último Teorema de Fermat em 1994?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Évariste Galois" },
            new Alternativa { Correta = false, Descricao = "Henri Poincaré" },
            new Alternativa { Correta = false, Descricao = "David Hilbert" },
            new Alternativa { Correta = true, Descricao = "Andrew Wiles" }
        }
    },
    new Pergunta
    {
        Id = 7,
        Enunciado = "Qual é o nome do efeito que faz com que um objeto em movimento se distorça devido à velocidade próxima à velocidade da luz?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Efeito Doppler" },
            new Alternativa { Correta = false, Descricao = "Efeito Hall" },
            new Alternativa { Correta = false, Descricao = "Efeito Zeeman" },
            new Alternativa { Correta = true, Descricao = "Contração do Tempo" }
        }
    },
    new Pergunta
    {
        Id = 8,
        Enunciado = "Qual é a teoria que descreve a origem e evolução do universo a partir de um estado extremamente quente e denso?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Teoria do Big Bang" },
            new Alternativa { Correta = false, Descricao = "Teoria da Evolução" },
            new Alternativa { Correta = false, Descricao = "Teoria da Relatividade" },
            new Alternativa { Correta = true, Descricao = "Teoria do Big Bang" }
        }
    },
    new Pergunta
    {
        Id = 9,
        Enunciado = "Qual é o nome da partícula subatômica responsável pela interação forte?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Elétron" },
            new Alternativa { Correta = false, Descricao = "Neutrino" },
            new Alternativa { Correta = false, Descricao = "Múon" },
            new Alternativa { Correta = true, Descricao = "Glúon" }
        }
    },
    new Pergunta
    {
        Id = 10,
        Enunciado = "Qual é o nome do filósofo grego conhecido por sua contribuição à lógica e ao método científico?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Platão" },
            new Alternativa { Correta = false, Descricao = "Sócrates" },
            new Alternativa { Correta = false, Descricao = "Aristóteles" },
            new Alternativa { Correta = true, Descricao = "Aristóteles" }
        }
    },
    new Pergunta
    {
        Id = 11,
        Enunciado = "Qual é o nome do matemático e físico que introduziu a equação que descreve o comportamento da luz e da matéria em termos de ondas e partículas?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Niels Bohr" },
            new Alternativa { Correta = false, Descricao = "Werner Heisenberg" },
            new Alternativa { Correta = false, Descricao = "Paul Dirac" },
            new Alternativa { Correta = true, Descricao = "Erwin Schrödinger" }
        }
    },
    new Pergunta
    {
        Id = 12,
        Enunciado = "Qual é a constante fundamental que mede a força da interação gravitacional?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Constante de Planck" },
            new Alternativa { Correta = false, Descricao = "Constante de Boltzmann" },
            new Alternativa { Correta = false, Descricao = "Constante de Avogadro" },
            new Alternativa { Correta = true, Descricao = "Constante gravitacional" }
        }
    },
    new Pergunta
    {
        Id = 13,
        Enunciado = "Qual é o nome do fenômeno onde uma onda de luz é desviada devido à presença de um campo gravitacional forte?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Efeito Doppler" },
            new Alternativa { Correta = false, Descricao = "Efeito Hall" },
            new Alternativa { Correta = false, Descricao = "Efeito Zeeman" },
            new Alternativa { Correta = true, Descricao = "Lentes Gravitacionais" }
        }
    },
    new Pergunta
    {
        Id = 14,
        Enunciado = "Qual é o nome do fenômeno onde a luz é dividida em cores ao passar através de um prisma?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Difração" },
            new Alternativa { Correta = false, Descricao = "Reflexão" },
            new Alternativa { Correta = false, Descricao = "Dispersão" },
            new Alternativa { Correta = true, Descricao = "Dispersion" }
        }
    },
    new Pergunta
    {
        Id = 15,
        Enunciado = "Quem foi o matemático e astrônomo que desenvolveu as leis do movimento planetário e a teoria heliocêntrica?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Galileu Galilei" },
            new Alternativa { Correta = false, Descricao = "Isaac Newton" },
            new Alternativa { Correta = false, Descricao = "Johannes Kepler" },
            new Alternativa { Correta = true, Descricao = "Johannes Kepler" }
        }
    },
    new Pergunta
    {
        Id = 16,
        Enunciado = "Qual é o nome da equação que descreve a relação entre a energia e a massa de uma partícula?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Equação de Heisenberg" },
            new Alternativa { Correta = false, Descricao = "Equação de Dirac" },
            new Alternativa { Correta = false, Descricao = "Equação de Schrödinger" },
            new Alternativa { Correta = true, Descricao = "Equação de Einstein" }
        }
    },
    new Pergunta
    {
        Id = 17,
        Enunciado = "Qual é a teoria que descreve a interação entre a matéria e o campo eletromagnético?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Teoria da Relatividade Geral" },
            new Alternativa { Correta = false, Descricao = "Teoria das Cordas" },
            new Alternativa { Correta = false, Descricao = "Teoria da Gravitação" },
            new Alternativa { Correta = true, Descricao = "Eletrodinâmica Quântica" }
        }
    },
    new Pergunta
    {
        Id = 18,
        Enunciado = "Qual é o nome da constante que relaciona a energia de um fóton com sua frequência?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Constante de Planck" },
            new Alternativa { Correta = false, Descricao = "Constante de Boltzmann" },
            new Alternativa { Correta = false, Descricao = "Constante de Avogadro" },
            new Alternativa { Correta = true, Descricao = "Constante de Planck" }
        }
    },
    new Pergunta
    {
        Id = 19,
        Enunciado = "Quem formulou o teorema que estabelece que em qualquer triângulo, a soma dos ângulos internos é sempre 180 graus?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Euclides" },
            new Alternativa { Correta = false, Descricao = "Pitagoras" },
            new Alternativa { Correta = false, Descricao = "Aristóteles" },
            new Alternativa { Correta = true, Descricao = "Euclides" }
        }
    },
    new Pergunta
    {
        Id = 20,
        Enunciado = "Qual é o nome do teorema matemático que afirma que em qualquer espaço vetorial, a soma dos ângulos internos de um triângulo é 180 graus?",
        Alternativas = new()
        {
            new Alternativa { Correta = false, Descricao = "Teorema de Gauss" },
            new Alternativa { Correta = false, Descricao = "Teorema de Riemann" },
            new Alternativa { Correta = false, Descricao = "Teorema de Pythagoras" },
            new Alternativa { Correta = true, Descricao = "Teorema de Euclides" }
        }
    },
};
        

        static List<Pergunta> perguntas_sorteadas = new();

            public static Pergunta getRandomPerguntaFacil()
                    {
                        
                        Random r = new Random();
                        Pergunta pergunta_sorteada;

            while (true) { 
                        int sorteado = r.Next(1, 20);

                        perguntas_sorteadas = perguntas_faceis[sorteado];
                if (!perguntas_faceis.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
                       }
            return pergunta_sorteada;
                    }

             public static Pergunta getRandomPerguntaMedia()
                    {

            Random r = new Random();
            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(1, 20);

                perguntas_sorteadas = perguntas_medianas[sorteado];
                if (!perguntas_medianas.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
            }
            return pergunta_sorteada;
        }
        
        public static Pergunta getRandomPerguntaDificil()
        {

            Random r = new Random();
            Pergunta pergunta_sorteada;

            while (true)
            {
                int sorteado = r.Next(1, 20);

                perguntas_sorteadas = perguntas_dificeis[sorteado];
                if (!perguntas_dificeis.Contains(pergunta_sorteada))
                {
                    perguntas_sorteadas.Add(pergunta_sorteada);
                    break;
                }
            }
            return pergunta_sorteada;
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
