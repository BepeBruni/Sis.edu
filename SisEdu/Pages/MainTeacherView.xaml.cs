namespace SisEdu.Pages;

public partial class MainTeacherView : ContentPage
{
	public MainTeacherView(MainTeacherViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}