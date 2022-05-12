using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_06_Fehler_Float
{
  [Start]
  public void Function()
  {
    float result;
    result = 10 / 3;
    MessageBox.Show("10 / 3 = " + result.ToString());
  }
}