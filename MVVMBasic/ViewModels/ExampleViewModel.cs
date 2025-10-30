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
        #region get and set
        // get and set for MessageForEldan
        private string messageForEldan;
        public string MessageForEldan
        {
          get { return messageForEldan; }
          set {
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
        #endregion

        #region Commands
        public ICommand ResetCommand { get; set; }
        public ICommand GotoAnotherPageCommand { get; set; }
        #endregion

        # region constructor
        public ExampleViewModel() {

            // Defining the Command for a non async Function
            ResetCommand = new Command(ResetField);
            // Defining the Command for an async Function
            GotoAnotherPageCommand = new Command(async () => await GotoAnotherPage());
        }
        #endregion

        #region  Methods
        private void ResetField()
        {
          UserInput = "";
          MessageForEldan = "";
        }

        private async Task GotoAnotherPage()
        {
            MainPage mp = new MainPage();
            await Application.Current.MainPage.Navigation.PushAsync(mp);

        }
        #endregion

    }
}
