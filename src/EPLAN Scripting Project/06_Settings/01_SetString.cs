using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _05_Settings_01_SetString
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();

    settings.SetStringSetting("USER.TrDMProject.UserData.Identification", "TEST", 0);

    MessageBox.Show("Setting has been set.");
  }
}