
using MVVMBasic.Views;

namespace MVVMBasic
{
  using MVVMBasic.Views;
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
      return new Window(new ExamplePage());
    }
  }
}
