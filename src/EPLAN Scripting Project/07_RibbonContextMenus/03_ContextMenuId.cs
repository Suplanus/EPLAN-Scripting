using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _07_RibbonContextMenus_03_ContextMenuId
{
  [DeclareRegister]
  public void Register()
  {
    Settings settings = new Settings();

    settings.SetBoolSetting("USER.EnfMVC.ContextMenuSetting.ShowIdentifier", true, 0);

    MessageBox.Show("Context menu id: visible");
  }

  [DeclareUnregister]
  public void UnRegister()
  {
    Settings settings = new Settings();

    settings.SetBoolSetting("USER.EnfMVC.ContextMenuSetting.ShowIdentifier", false, 0);

    MessageBox.Show("Context menu id: invisible");
  }
}