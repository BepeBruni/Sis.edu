namespace SisEdu.Pages;

public partial class LoginTeacherView : ContentPage
{
	public LoginTeacherView(LoginTeacherViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}