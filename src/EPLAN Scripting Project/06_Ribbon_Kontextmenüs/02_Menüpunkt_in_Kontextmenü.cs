using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _06_Ribbon_Kontextmenues_02_Menuepunkt_in_Kontextmenue
{
  [DeclareAction("MenuAction")]
  public void ActionFunction()
  {
    MessageBox.Show("Action wurde ausgeführt!");
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
        "Menüpunkt in Kontextmenü",
        "MenuAction",
        true,
        false
        );
  }
}