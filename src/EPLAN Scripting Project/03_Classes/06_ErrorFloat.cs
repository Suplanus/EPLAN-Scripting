using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_Classes_06_ErrorFloat
{
  [Start]
  public void Function()
  {
    float result;
    result = 10 / 3;
    MessageBox.Show("10 / 3 = " + result.ToString());
  }
}