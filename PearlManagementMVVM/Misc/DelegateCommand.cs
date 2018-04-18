namespace PearlManagementMVVM.Misc
{
  using System;
  using System.Windows.Input;

  public class DelegateCommand : ICommand
  {
    private readonly Action action;

    public DelegateCommand(Action action)
    {
      this.action = action;
    }

    public void Execute(object parameter)
    {
      this.action();
    }

    public bool CanExecute(object parameter)
    {
      return true;
    }

#pragma warning disable 67
    public event EventHandler CanExecuteChanged { add { } remove { } }
#pragma warning disable 67
  }
}
