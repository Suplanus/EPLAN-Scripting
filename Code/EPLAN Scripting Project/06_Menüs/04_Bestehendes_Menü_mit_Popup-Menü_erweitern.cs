using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _06_Menues_04_Bestehendes_Menue_mit_Popup_Menue_erweitern
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

    menu.AddPopupMenuItem(
        "Bestehendes Menü erweitern...", // Name: Menü
        "mit Popup-Menü", // Name: Menüpunkt
        "MenuAction", // Name: Action
        "Statustext", // Statustext
        37024, // Menü-ID: Einfügen/Fenstermakro...
        0, // 1 = hinter Menüpunkt, 0 = vor Menüpunkt
        false, // Separator davor anzeigen
        false // Separator dahinter anzeigen
        );

    return;
  }
}