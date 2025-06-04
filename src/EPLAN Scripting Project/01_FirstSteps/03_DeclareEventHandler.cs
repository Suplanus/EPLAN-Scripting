using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _01_FirstSteps_03_DeclareEventHandler
{
  [DeclareEventHandler("onActionStart.String.XPrjActionProjectClose")]
  public void Function()
  {
    MessageBox.Show("Scripting is great!");
  }
}