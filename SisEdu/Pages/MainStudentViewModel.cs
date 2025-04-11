using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Database;
using Firebase.Database.Query;
using SisEdu.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEdu.Pages
{
    public partial class MainStudentViewModel : ObservableObject
    {
        private readonly FirebaseClient _firebaseClient;

        public ObservableCollection<Curso> CursosList { get; set; } = new ObservableCollection<Curso>();

        public MainStudentViewModel(FirebaseClient firebaseClient)
        {
            _firebaseClient = firebaseClient;
            LoadDataAsync();
            
        }

        

        [RelayCommand]
        private async Task Student()
        {
            List<string> _paginas =
            [
                "### Introdução:\nO lançamento oblíquo é um dos temas fundamentais da cinemática e está amplamente presente no cotidiano, especialmente em esportes como futebol, vôlei e basquete. Além de ser um conceito frequentemente abordado em vestibulares, ele também possui aplicações em áreas estratégicas da economia e da tecnologia. Por exemplo, a NASA, em parceria com a SpaceX, anunciou em agosto de 2022 a ampliação de um contrato para missões tripuladas à Estação Espacial Internacional, elevando o valor total para quase US$ 5 bilhões. Além disso, o Departamento de Defesa dos Estados Unidos solicitou US$ 24,7 bilhões para defesa contra mísseis e US$ 34,4 bilhões para modernização da capacidade nuclear, evidenciando a importância desse conhecimento na área militar e aeroespacial. Dessa forma, o estudo do lançamento oblíquo vai muito além da sala de aula, tendo impacto direto no desenvolvimento científico e tecnológico da sociedade.\n### Teoria:\nAs fórmulas do lançamento obliquo são usadas para calcular a trajetória de um determinado objeto que foi lançado no ar a determinado ângulo e velocidade, podendo-se extrair informações como o tempo de voo, altura máxima e alcance máximo. A trajetória se baseia no principio do plano cartesiano, sendo expresso como coordenadas em (x, y).\n#### Fórmulas:\n###### - calculando o cosseno: \ncos(0) = cateto adjacente ÷ hipotenusa\n###### - calculando o seno:\n**sin(0)** = cateto oposto ÷ hipotenusa\n### Exemplos:\n1 - Um atleta arremessa uma pedra com velocidade de **20 m/s**, formando um ângulo de **60°** com a horizontal. Despreze a resistência do ar e considere g=10 m/s2g = 10 \n, m/s^2g=10m/s2.\n**Pergunta**:\na) Qual é o tempo total de voo da pedra?\nb) Qual é\ndistância horizontal total (alcance)?\nResolução:\nPasso 1: Decompor a velocidade inicial\nV₀ = 20 m/s\nV₀x = V₀ * cos(60°) = 20 * 0,5 = 10 m/s\nV₀y = V₀ * sin(60°) = 20 * 0,866 ≈ 17,32 m/s\na) Tempo total de voo:\nt = V₀y / g = 17,32 / 10 ≈ 1,732 s\nt(total) = 2 * t = 2 * 1,732 ≈ 3,464 s\nb) Alcance horizontal:\nR = V₀x * T(total) = 10 * 3,464 ≈ 34,64 m",
                "2 - Um objeto é lançado horizontalmente do topo de um prédio com velocidade de 18 m/s, a partir de uma altura de 45 m. Considere g = 10 m/s² e despreze a resistência do ar.\nPergunta:\na) Quanto tempo o objeto leva para atingir o solo?\nb) Qual a distância horizontal percorrida até o impacto?\nResolução:\na) Tempo de queda vertical:\nh = (1/2) * g * t² \n45 = (1/2) * 10 * t² \n45 = 5 * t² \nt² = 9 \nt = 3 s\nb) Distância horizontal: \nΔx = v * t = 18 * 3 = 54 m",
            ];


            await _firebaseClient.Child("Curso").PostAsync(new Curso
            {
                Id = 1,
                Tema = "Fisica",
                Paginas = _paginas,
                Prof = "Teste"
            });



        }

        [RelayCommand]
        private async Task NavigateLoginTeacher()
        {
            await Shell.Current.GoToAsync("//LoginTeacher");
        }

        [RelayCommand]
        private async Task NavigateMainStudent()
        {
            //await Student();
            await Shell.Current.GoToAsync("//LoginTeacher");
        }

        public async Task LoadDataAsync()
        {
            _firebaseClient.Child("Curso").AsObservable<Curso>().Subscribe((item) =>
            {
                if (item.Object != null)
                {
                    CursosList.Add(item.Object);
                }
            });
        }
    }
}
