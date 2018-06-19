using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _10_Dateien_und_Ordner_04_Datei_mit_Datumsstempel
{
  [Start]
  public void Function()
  {
    string date = DateTime.Now.ToString("yyyy-MM-dd");
    string time = DateTime.Now.ToString("HH-mm-ss");
    string fileName = @"C:\test\test_" + date + "_" + time + ".txt";

    FileStream fileStream = File.Create(fileName);
    fileStream.Dispose();
    MessageBox.Show("Datei erstellt.");

    return;
  }
}