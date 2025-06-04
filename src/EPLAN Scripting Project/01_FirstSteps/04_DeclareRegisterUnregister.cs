using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _01_FirstSteps_04_DeclareRegisterUnregister
{
  [DeclareRegister]
  public void Register()
  {
    MessageBox.Show("Script loaded.");
  }

  [DeclareUnregister]
  public void UnRegister()
  {
    MessageBox.Show("Script unloaded.");
  }
}