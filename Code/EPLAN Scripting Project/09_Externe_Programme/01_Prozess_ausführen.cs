using System;
using System.Diagnostics;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _09_Externe_Programme_01_Prozess_ausfuehren
{
  [Start]
  public void Function()
  {
    try
    {
      Process.Start("calc");
    }
    catch (Exception ex)
    {
      MessageBox.Show(
          ex.Message,
          "Fehler",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error
          );
    }

    return;
  }
}