using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _01_Erste_Schritte_03_DeclareEventHandler
{
  [DeclareEventHandler("onActionStart.String.XPrjActionProjectClose")]
  public void Function()
  {
    MessageBox.Show("Ich kann scripten!");
    return;
  }
}