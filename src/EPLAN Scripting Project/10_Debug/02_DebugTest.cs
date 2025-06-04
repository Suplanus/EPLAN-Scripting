using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using System;
using System.Diagnostics;

public class _10_Debug_02_DebugTest
{
  [Start]
  public void Function()
  {
    if (Debugger.IsAttached)
    {
      Debugger.Break();
    }

    int result;
    int number1 = 10;
    int number2 = 0;

    if (Debugger.IsAttached)
    {
      Debug.WriteLine(number1 + ":" + number2);
    }

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