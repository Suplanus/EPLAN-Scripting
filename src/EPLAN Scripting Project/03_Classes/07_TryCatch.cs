using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using System;

public class _03_Classes_07_TryCatch
{
  [Start]
  public void Function()
  {
    int result;
    int number1 = 10;
    int number2 = 0;

    try
    {
      result = number1 / number2;

      // No more code is executed from here
      MessageBox.Show(result.ToString());
      MessageBox.Show("Calculation successfully completed.");
    }
    catch (Exception exception)
    {
      MessageBox.Show(exception.Message);
    }
  }
}