using System;
using System.Diagnostics;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _11_ExternalApplications_01_RunProcess
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
      MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}