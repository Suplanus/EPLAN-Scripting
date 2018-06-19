using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _05_Settings_05_Lesen_Bool
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();

    bool useLoginName = settings.GetBoolSetting(
    "USER.XUserSettingsGui.UseLoginName", 0);

    if (useLoginName)
    {
      MessageBox.Show("Einstellung ist aktiviert.");
    }
    else
    {
      MessageBox.Show("Einstellung ist deaktiviert.");
    }

    return;
  }
}