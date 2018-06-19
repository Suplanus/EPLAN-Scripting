using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _06_Menues_01_Menuepunkt_in_Dienstprogramme
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

    menu.AddMenuItem(
        "Menüpunkt am Ende von Dienstprogramme", // Name: Menüpunkt
        "MenuAction" // Name: Action
        );

    return;
  }
}