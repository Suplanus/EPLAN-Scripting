using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_Classes_10_ParameterInteger
{
  [DeclareAction("IntParameter")]
  public void Function(int int1, int int2)
  {
    int result = int1 + int2;

    string message = int1.ToString() + " + " + int2.ToString() + " = " + result.ToString();

    MessageBox.Show(message);
  }
}