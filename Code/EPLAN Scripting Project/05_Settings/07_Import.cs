using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _05_Settings_07_Import
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();

    settings.ReadSettings(@"C:\test\test.xml");

    MessageBox.Show("Einstellungen wurden importiert.");

    return;
  }
}