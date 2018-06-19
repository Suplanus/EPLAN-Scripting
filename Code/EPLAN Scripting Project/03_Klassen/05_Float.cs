using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_Klassen_05_Float
{
  [Start]
  public void Function()
  {
    float result;
    float number1 = 10;
    float number2 = 3;

    result = number1 / number2;
    MessageBox.Show(result.ToString());

    return;
  }
}