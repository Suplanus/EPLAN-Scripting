using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _06_Menues_07_Kontextmenue_ID
{
  [DeclareRegister]
  public void Register()
  {
    Settings settings = new Settings();

    settings.SetBoolSetting(
        "USER.EnfMVC.ContextMenuSetting.ShowIdentifier",
        true,
        0
        );

    MessageBox.Show("Kontextmenü-ID: sichtbar");

    return;
  }

  [DeclareUnregister]
  public void UnRegister()
  {
    Settings settings = new Settings();

    settings.SetBoolSetting(
        "USER.EnfMVC.ContextMenuSetting.ShowIdentifier",
        false,
        0
        );

    MessageBox.Show("Kontextmenü-ID: unsichtbar");

    return;
  }
}