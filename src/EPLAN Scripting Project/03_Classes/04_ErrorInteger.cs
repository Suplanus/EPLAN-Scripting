using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_Classes_04_ErrorInteger
{
  [Start]
  public void Function()
  {
    string number1String = "10";
    string number2String = "2";
    string resultString = number1String + number2String;
    MessageBox.Show(resultString);

    int result;
    int number1 = 10;
    int number2 = 0;
    result = number1 / number2;
    MessageBox.Show(result.ToString());
  }
}