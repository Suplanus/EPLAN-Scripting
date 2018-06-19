using System;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _11_Dateien_oeffnen_speichern_OpenFileDialog
{
  [Start]
  public void Function()
  {
    string projectPath = PathMap.SubstitutePath("$(PROJECTPATH)");
    string fileName = "Testdatei";

    OpenFileDialog ofd = new OpenFileDialog();
    ofd.DefaultExt = "txt";
    ofd.FileName = fileName;
    ofd.Filter = "Testdatei (*Testdatei*.txt)|*Testdatei*.txt" +
      "|Alle Dateien (*.*)|*.*";
    ofd.InitialDirectory = projectPath;
    ofd.Title = "Testdatei auswählen:";
    ofd.ValidateNames = true;

    if (ofd.ShowDialog() == DialogResult.OK)
    {
      fileName = ofd.FileName;
      MessageBox.Show("Der Speicherort wurde erfolgreich übergeben:" +
                      Environment.NewLine +
                      fileName,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
      );
    }

    return;
  }
}