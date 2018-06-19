using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _05_Settings_04_Lesen_String
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();

    string name = settings.GetStringSetting(
      "USER.TrDMProject.UserData.Longname", 0);

    MessageBox.Show("Hallo " + name + "!");

    return;
  }
}