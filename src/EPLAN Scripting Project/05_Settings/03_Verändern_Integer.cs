using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _05_Settings_03_Veraendern_Integer
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();

    settings.SetNumericSetting(
        "USER.SYSTEM.GUI.LAST_PROJECTS_COUNT",
        11, 0);

    MessageBox.Show("Einstellung wurde gesetzt.");
  }
}