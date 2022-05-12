using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using System;
using System.Diagnostics;

public class _03_Klassen_07_TryCatch
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

      // Ab hier wird kein Code mehr ausgeführt
      MessageBox.Show(result.ToString());
      MessageBox.Show("Berechnung erfolgreich beendet");
    }
    catch (Exception exception)
    {
      MessageBox.Show(exception.Message);
    }
  }
}