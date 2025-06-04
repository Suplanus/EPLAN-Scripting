using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _01_FirstSteps_02_DeclareAction
{
  [DeclareAction("ActionName")]
  public void Function()
  {
    MessageBox.Show("Scripting is great!");
  }
}