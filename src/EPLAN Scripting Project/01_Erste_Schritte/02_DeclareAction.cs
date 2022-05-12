using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _01_Erste_Schritte_02_DeclareAction
{
  [DeclareAction("Actionname")]
  public void Function()
  {
    MessageBox.Show("Ich kann scripten!");
  }
}