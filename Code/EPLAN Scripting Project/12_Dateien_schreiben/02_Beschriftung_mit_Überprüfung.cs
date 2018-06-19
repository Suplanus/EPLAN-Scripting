using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _12_Dateien_schreiben_02_Beschriftung_mit_Ueberpruefung
{
  [Start]
  public void Function()
  {
    string fileName;

    fileName = GetFileName("Artikelsummenstückliste.xls");
    if (fileName != null)
    {
      ActionCallingContext context1 = new ActionCallingContext();
      context1.AddParameter("configscheme", "Summarized parts list");
      context1.AddParameter("filterscheme", "");
      context1.AddParameter("sortscheme", "");
      context1.AddParameter("language", "de_DE");
      context1.AddParameter("destinationfile", fileName);
      context1.AddParameter("recrepeat", "1");
      context1.AddParameter("taskrepeat", "1");
      context1.AddParameter("showoutput", "1");
      context1.AddParameter("type", "PROJECT");
      new CommandLineInterpreter().Execute("label", context1);
    }

    fileName = GetFileName("Betriebsmittelbeschriftung.xls");
    if (fileName != null)
    {
      ActionCallingContext context2 = new ActionCallingContext();
      context2.AddParameter("configscheme", "Device tag list");
      context2.AddParameter("filterscheme", "");
      context2.AddParameter("sortscheme", "");
      context2.AddParameter("language", "de_DE");
      context2.AddParameter("destinationfile", fileName);
      context2.AddParameter("recrepeat", "1");
      context2.AddParameter("taskrepeat", "1");
      context2.AddParameter("showoutput", "1");
      context2.AddParameter("type", "PROJECT");
      new CommandLineInterpreter().Execute("label", context2);
    }

    return;
  }

  private static string GetFileName(string fileName)
  {
    string projectPath = PathMap.SubstitutePath("$(PROJECTPATH)");
    string fullFileName = Path.Combine(projectPath, fileName);

    if (File.Exists(fullFileName))
    {
      DialogResult dialogResult = MessageBox.Show(
        "Die Datei'" +
        Environment.NewLine +
        fullFileName +
        Environment.NewLine +
        "'" +
        Environment.NewLine +
        "existiert bereits." +
        Environment.NewLine +
        "Wollen Sie die Datei überschreiben?",
        "Beschriftung",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
      );

      if (dialogResult == DialogResult.No)
      {
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.DefaultExt = "xls";
        sfd.FileName = fileName;
        sfd.Filter = "Excel-Datei (*.xlsx)|*.xlsx";
        sfd.InitialDirectory = projectPath;
        sfd.Title = "Speicherort für " + fileName + " wählen:";
        sfd.ValidateNames = true;

        DialogResult sfdDialogResult = sfd.ShowDialog();
        if (sfdDialogResult == DialogResult.OK)
        {
          fullFileName = sfd.FileName;
        }
        else if (sfdDialogResult == DialogResult.Cancel)
        {
          fullFileName = null;
        }
      }

    }
    return fullFileName;
  }
}