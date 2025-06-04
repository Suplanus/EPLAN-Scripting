using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _07_RibbonContextMenus_02_ContextMenu
{
  [DeclareAction("MenuAction")]
  public void ActionFunction()
  {
    MessageBox.Show("Action was executed!");
  }

  [DeclareMenu]
  public void MenuFunction()
  {
    Eplan.EplApi.Gui.ContextMenuLocation contextMenuLocation =
        new Eplan.EplApi.Gui.ContextMenuLocation(
            "GedEditGuiText",
            "1002"
            );

    Eplan.EplApi.Gui.ContextMenu menu = 
      new Eplan.EplApi.Gui.ContextMenu();
    menu.AddMenuItem(
        contextMenuLocation,
        "Menu item in context menu",
        "MenuAction",
        true,
        false
        );
  }
}