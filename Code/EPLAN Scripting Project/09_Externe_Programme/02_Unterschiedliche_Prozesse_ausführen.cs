using System;
using System.Diagnostics;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _09_Externe_Programme_02_Unterschiedliche_Prozesse_ausfuehren
{
  [DeclareAction("StartProcess")]
  public void Function(string processName, string parameter)
  {
    try
    {
      parameter = PathMap.SubstitutePath(parameter);
      Process.Start(processName, parameter);
    }
    catch (Exception ex)
    {
      MessageBox.Show(
          ex.Message,
          "Fehler",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error
          );
    }

    return;
  }

  [DeclareMenu]
  public void MenuFunction()
  {
    Eplan.EplApi.Gui.Menu menu = new Eplan.EplApi.Gui.Menu();

    uint menuId; // Menü-ID vom neu erzeugten Menü

    menuId = menu.AddMainMenu(
        "Externe Programme", // Name: Menü
        "Hilfe", // neben Menüpunkt
        "Taschenrechner", // Name: Menüpunkt
        "StartProcess /processName:calc /parameter:''", // Name: Action
        "Taschenrechner öffnen...", // Statustext
        1 // 1 = Hinter Menüpunkt, 0 = Vor Menüpunkt
        );

    string quote = "\"";

    menuId = menu.AddMenuItem(
        "Projektordner öffnen", // Name: Menüpunkt
        "StartProcess /processName:explorer /parameter:"
            + quote + "$(PROJECTPATH)" + quote, // Name: Action
        "Projektordner im Explorer öffnen...", // Statustext
        menuId, // Menü-ID: Einfügen/Fenstermakro...
        1, // 1 = Hinter Menüpunkt, 0 = Vor Menüpunkt
        false, // Separator davor anzeigen
        false // Separator dahinter anzeigen
        );

    menuId = menu.AddMenuItem(
        "Zeichentabelle", // Name: Menüpunkt
        "StartProcess /processName:charmap /parameter:''", // Name: Action
        "Zeichentabelle öffnen...", // Statustext
        menuId, // Menü-ID: Einfügen/Fenstermakro...
        1, // 1 = Hinter Menüpunkt, 0 = Vor Menüpunkt
        false, // Separator davor anzeigen
        false // Separator dahinter anzeigen
        );

    string pdfFile = @"C:\test\test.pdf";

    menuId = menu.AddMenuItem(
        "PDF öffnen", // Name: Menüpunkt
        "StartProcess /processName:" + quote + pdfFile + quote + // Name: Action
        " /parameter:''",
        "Beispiel PDF öffnen...", // Statustext
        menuId, // Menü-ID: Einfügen/Fenstermakro...
        1, // 1 = Hinter Menüpunkt, 0 = Vor Menüpunkt
        false, // Separator davor anzeigen
        false // Separator dahinter anzeigen
        );

    return;

  }
}