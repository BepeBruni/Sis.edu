namespace SisEdu.Pages;

public partial class MainStudentView : ContentPage
{
	public MainStudentView(MainStudentViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}