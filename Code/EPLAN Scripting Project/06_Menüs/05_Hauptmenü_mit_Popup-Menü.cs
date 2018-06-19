using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _06_Menues_05_Hauptmenue_mit_Popup_Menue
{
  [DeclareAction("MenuAction")]
  public void ActionFunction()
  {
    MessageBox.Show("Action wurde ausgeführt!");

    return;
  }

  [DeclareMenu]
  public void MenuFunction()
  {
    Eplan.EplApi.Gui.Menu menu = new Eplan.EplApi.Gui.Menu();

    uint menuId = new uint(); // Menü-ID vom neu erzeugten Menü
    menuId = menu.AddMainMenu( // Festlegen der Menü-ID des Objekts
        "Menü 2", // Name: Menü
        Eplan.EplApi.Gui.Menu.MainMenuName.eMainMenuHelp, // neben Menüpunkt
        "Hauptmenü mit einem Menüpunkt", // Name: Menüpunkt
        "MenuAction", // Name: Action
        "Statustext", // Statustext
        1 // 1 = hinter Menüpunkt, 0 = vor Menüpunkt
        );

    menu.AddPopupMenuItem(
        "Popup-Menü mit...", // Name: Menü
        "Unterpunkt", // Name: Menüpunkt
        "MenuAction", // Name: Action
        "Statustext", // Statustext
        menuId, // Menü-ID
        1, // 1 = hinter Menüpunkt, 0 = vor Menüpunkt
        true, // Separator davor anzeigen
        false // Separator dahinter anzeigen
        );

    return;
  }
}