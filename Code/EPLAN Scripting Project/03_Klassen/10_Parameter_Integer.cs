using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_Klassen_10_Parameter_Integer
{
  [DeclareAction("IntParameter")]
  public void Function(int int1, int int2)
  {
    int resultInt = int1 + int2;

    string message = int1.ToString() +
        " + " + int2.ToString() +
        " = " + resultInt.ToString();

    MessageBox.Show(message);

    return;
  }
}