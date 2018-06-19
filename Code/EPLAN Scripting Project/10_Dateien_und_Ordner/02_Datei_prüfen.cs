using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _10_Dateien_und_Ordner_02_Datei_pruefen
{
  [Start]
  public void Function()
  {
    string fileName = @"C:\test\test.txt";

    if (File.Exists(fileName))
    {
      MessageBox.Show("Datei schon vorhanden.");
    }
    else
    {
      FileStream fileStream = File.Create(fileName);
      fileStream.Dispose();
      MessageBox.Show("Datei erstellt.");
    }

    return;
  }
}