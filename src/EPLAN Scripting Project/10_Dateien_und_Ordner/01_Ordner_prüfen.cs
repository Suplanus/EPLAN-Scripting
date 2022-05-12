using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _10_Dateien_und_Ordner_01_Ordner_pruefen
{
  [Start]
  public void Function()
  {
    string path = @"C:\test\";

    if (Directory.Exists(path))
    {
      MessageBox.Show("Ordner schon vorhanden.");
    }
    else
    {
      Directory.CreateDirectory(path);
      MessageBox.Show("Ordner erstellt.");
    }
  }
}