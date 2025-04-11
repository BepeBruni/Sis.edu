using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEdu.Pages
{
    public partial class LoginTeacherViewModel : ObservableObject
    {

        [RelayCommand]
        private async Task NavigateLoginStudent()
        {
            await Shell.Current.GoToAsync("//LoginStudent");
        }

        [RelayCommand]
        private async Task NavigateMainTeacher()
        {
            await Shell.Current.GoToAsync("//MainTeacher");
        }

    }
}
