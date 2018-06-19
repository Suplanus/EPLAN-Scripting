using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _06_Menues_03_Hauptmenue_mit_Untermenuepunkt
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

    menu.AddMainMenu(
        "Menü 1", // Name: Menü
        Eplan.EplApi.Gui.Menu.MainMenuName.eMainMenuHelp, // neben Menüpunkt
        "Hauptmenü mit einem Menüpunkt", // Name: Menüpunkt
        "MenuAction", // Name: Action
        "Statustext", // Statustext
        1 // 1 = hinter Menüpunkt, 0 = vor Menüpunkt
        );

    return;
  }
}