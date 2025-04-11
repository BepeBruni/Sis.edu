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
    public partial class CreateTeacherViewModel : ObservableObject
    {
        Random rnd = new Random();

        public ObservableCollection<Student> StudentList { get; set; } = new ObservableCollection<Student>();

        private readonly FirebaseClient _firebaseClient;

        [ObservableProperty]
        private string _id;

        [ObservableProperty]
        private string _name;


        

        private string _password;

        public string ConsoleStudent => _password;


        public CreateTeacherViewModel(FirebaseClient firebaseClient)
        {
            _firebaseClient = firebaseClient;
        }

        

        [RelayCommand]
        private async Task Student()
        {

            _password = rnd.Next(10000000, 99999999).ToString();

            await _firebaseClient.Child("Student").PostAsync(new Student
            {
                Name = _name,
                Id = Int32.Parse(_id),
                password = _password
            });


            await Shell.Current.DisplayAlert("Aluno Cadastrado", _name + "\nId: " + _id + "\nSenha: " + _password, "OK");

            Application.Current.MainPage.Dispatcher.Dispatch(() => Name = "");
            Application.Current.MainPage.Dispatcher.Dispatch(() => Id = "");

            await LoadDataAsync();

        }

        public async Task LoadDataAsync()
        {
            _firebaseClient.Child("Student").AsObservable<Student>().Subscribe((item) =>
            {
                if (item.Object != null)
                {
                    StudentList.Add(item.Object);
                }
            });
        }

        [RelayCommand]
        private async Task NavigateMainTeacher()
        {
            await Shell.Current.GoToAsync("//MainTeacher");
        }
    }
}
