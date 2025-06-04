using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_Classes_03_Integer
{
  [Start]
  public void Function()
  {
    int result;
    int number1 = 6;
    int number2 = 3;

    MessageBox.Show(number1.ToString());

    result = number1 + number2;
    MessageBox.Show(result.ToString());

    result = number1 - number2;
    MessageBox.Show(result.ToString());

    result = number1 * number2;
    MessageBox.Show(result.ToString());

    result = number1 / number2;
    MessageBox.Show(result.ToString());
  }
}