namespace SisEdu.Pages;

public partial class LoginStudentView : ContentPage
{
	public LoginStudentView(LoginStudentViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}