using MVVMBasic.ViewModels;
namespace MVVMBasic.Views;

public partial class ExamplePage : ContentPage
{
	public ExamplePage()
	{
		InitializeComponent();
    BindingContext = new ExampleViewModel();
  }
}
