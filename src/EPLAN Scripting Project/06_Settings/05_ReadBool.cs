using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _05_Settings_05_ReadBool
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();

    bool useLoginName = settings.GetBoolSetting("USER.XUserSettingsGui.UseLoginName", 0);

    if (useLoginName)
    {
      MessageBox.Show("Setting is activated.");
    }
    else
    {
      MessageBox.Show("Setting is deactivated.");
    }
  }
}