using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMBasic.ViewModels
{
  internal class ExampleViewModel :  ViewModelBase
  {
    // get and set for MessageForEldan
    private string messageForEldan;
    public string MessageForEldan
    {
      get { return messageForEldan; }
      set {
        // Basic
        //messageForEldan = value;
        //PropertyChanged();

        // Even Better
        if (value != null)
        {
          messageForEldan = value;
          OnPropertyChanged();
        }
      }
    }

    // get and set for UserInput
    public string userInput;
    public string UserInput
    {
      get { return userInput; }
      set
      {
        userInput = value;
        if (userInput != null && userInput.Length > 5)
        {
          MessageForEldan = "The field has more than 5 characters";
        }
        else
        {
          MessageForEldan = "The field has 5 or fewer characters";
        }
        OnPropertyChanged();
      }
    }

    public ICommand ButtonResetCommand { get; set; }
    
    // constructor
    public ExampleViewModel() {
      ButtonResetCommand = new Command(ResetField);
    }

    private void ResetField()
    {
      UserInput = "";
      MessageForEldan = "";
    }
  }
}
