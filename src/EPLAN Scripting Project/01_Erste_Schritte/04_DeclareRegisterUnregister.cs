using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _01_Erste_Schritte_04_DeclareRegisterUnregister
{
  [DeclareRegister]
  public void Register()
  {
    MessageBox.Show("Script geladen.");
  }

  [DeclareUnregister]
  public void UnRegister()
  {
    MessageBox.Show("Script entladen.");
  }
}