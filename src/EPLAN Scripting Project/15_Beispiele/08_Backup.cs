using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _15_Beispiele_08_Backup
{
  [Start]
  public void Function()
  {
    string projectsPath = PathMap.SubstitutePath("$(MD_PROJECTS)");
    string projectName = PathMap.SubstitutePath("$(PROJECTNAME)");

    string date = DateTime.Now.ToString("yyyy-MM-dd");
    string time = DateTime.Now.ToString("HH-mm-ss");

    string backupDirectory = Path.Combine(projectsPath, "Backup");
    string backupFileName = projectName + "_" +
      date + "_" + time + ".zw1";
    string backupFullFileName = 
      Path.Combine(backupDirectory, backupFileName);

    if (!Directory.Exists(backupDirectory))
    {
      Directory.CreateDirectory(backupDirectory);
    }

    Progress progress = new Progress("SimpleProgress");
    progress.SetAllowCancel(true);
    progress.SetAskOnCancel(true);
    progress.BeginPart(100, "");
    progress.SetTitle("Backup");
    progress.ShowImmediately();

    if (!progress.Canceled())
    {
      CommandLineInterpreter cli = new CommandLineInterpreter();
      ActionCallingContext acc = new ActionCallingContext();

      acc.AddParameter("BACKUPAMOUNT", "BACKUPAMOUNT_ALL");
      acc.AddParameter("BACKUPMEDIA", "DISK");
      acc.AddParameter("BACKUPMETHOD", "BACKUP");
      acc.AddParameter("COMPRESSPRJ", "1");
      acc.AddParameter("INCLEXTDOCS", "1");
      acc.AddParameter("INCLIMAGES", "1");
      acc.AddParameter("ARCHIVENAME", backupFileName);
      acc.AddParameter("DESTINATIONPATH", backupDirectory);
      acc.AddParameter("TYPE", "PROJECT");

      cli.Execute("backup", acc);
    }

    progress.EndPart(true);

    MessageBox.Show(
        "Backup wurde erfolgreich erstellt:" +
        Environment.NewLine +
        backupFullFileName,
        "Hinweis",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
        );
  }
}