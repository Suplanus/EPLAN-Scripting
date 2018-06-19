using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _11_Dateien_oeffnen_speichern_SaveFileDialog
{
  [Start]
  public void Function()
  {
    string projectPath = PathMap.SubstitutePath("$(PROJECTPATH)");
    string fileName = "Testdatei";

    SaveFileDialog sfd = new SaveFileDialog();
    sfd.DefaultExt = "txt";
    sfd.FileName = fileName;
    sfd.Filter = "Textdatei (*.txt)|*.txt";
    sfd.InitialDirectory = projectPath;
    sfd.Title = "Speicherort für Testdatei wählen:";
    sfd.ValidateNames = true;

    if (sfd.ShowDialog() == DialogResult.OK)
    {
      FileStream fileStream = File.Create(sfd.FileName);
      fileStream.Dispose();
      MessageBox.Show(
        "Datei wurde erfolgreich gespeichert:" + Environment.NewLine +
        sfd.FileName,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
      );
    }

    return;
  }
}