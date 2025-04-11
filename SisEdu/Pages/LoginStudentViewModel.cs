using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEdu.Pages
{
    public partial class LoginStudentViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task NavigateLoginTeacher()
        {
            await Shell.Current.GoToAsync("//LoginTeacher");
        }

        [RelayCommand]
        private async Task NavigateMainStudent()
        {
            await Shell.Current.GoToAsync("//MainStudent");
        }
    }
}
