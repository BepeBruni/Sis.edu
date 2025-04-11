using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEdu.Pages
{
    public partial class MainTeacherViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task NavigateMainTeacher()
        {
            await Shell.Current.GoToAsync("//MainTeacher");
        }

        [RelayCommand]
        private async Task NavigateCreateTeacher()
        {
            await Shell.Current.GoToAsync("//CreateTeacher");
        }
    }
}
