using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _05_Settings_04_ReadString
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();

    string name = settings.GetStringSetting("USER.TrDMProject.UserData.Longname", 0);

    MessageBox.Show("Hello " + name + "!");
  }
}