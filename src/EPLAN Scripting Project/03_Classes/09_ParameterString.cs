using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_Classes_09_ParameterString
{
  [DeclareAction("StringParameter")]
  public void Function(string parameter)
  {
    MessageBox.Show(parameter);
  }
}