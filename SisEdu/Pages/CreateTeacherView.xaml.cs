namespace SisEdu.Pages;

public partial class CreateTeacherView : ContentPage
{
	public CreateTeacherView(CreateTeacherViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}

}