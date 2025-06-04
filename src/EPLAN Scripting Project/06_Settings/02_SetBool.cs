using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _05_Settings_02_SetBool
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();

    settings.SetBoolSetting("USER.EnfMVC.ContextMenuSetting.ShowExtended", true, 0);

    MessageBox.Show("Setting has been activated. EPLAN restart required.");
  }
}