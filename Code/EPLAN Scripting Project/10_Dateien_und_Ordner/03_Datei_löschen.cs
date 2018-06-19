using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _10_Dateien_und_Ordner_03_Datei_loeschen
{
  [Start]
  public void Function()
  {
    string fileName = @"C:\test\test.txt";

    if (File.Exists(fileName))
    {
      File.Delete(fileName);
      MessageBox.Show("Datei gelöscht");
    }

    return;
  }
}