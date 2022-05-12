using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_Klassen_09_Parameter_String
{
  [DeclareAction("StringParameter")]
  public void Function(string parameter)
  {
    MessageBox.Show(parameter);
  }
}