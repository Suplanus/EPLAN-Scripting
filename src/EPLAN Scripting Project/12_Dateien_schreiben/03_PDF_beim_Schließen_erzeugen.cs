using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _12_Dateien_schreiben_03_PDF_beim_Schliessen_erzeugen
{
  [DeclareEventHandler("Eplan.EplApi.OnUserPreCloseProject")]
  public void Function()
  {
    string projectPath = PathMap.SubstitutePath("$(PROJECTPATH)");
    string projectName = PathMap.SubstitutePath("$(PROJECTNAME)");

    DialogResult dialogResult = MessageBox.Show(
        "Soll ein PDF für das Projekt'" +
        Environment.NewLine +
        projectName +
        "'" +
        Environment.NewLine +
        "erzeugt werden?",
        "PDF-Export",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
        );

    if (dialogResult == DialogResult.Yes)
    {
      Progress progress = new Progress("SimpleProgress");
      progress.SetAllowCancel(true);
      progress.SetAskOnCancel(true);
      progress.BeginPart(100, "");
      progress.ShowImmediately();

      CommandLineInterpreter cli = new CommandLineInterpreter();
      ActionCallingContext acc = new ActionCallingContext();

      string fullFileName = Path.Combine(projectPath, projectName);
      acc.AddParameter("TYPE", "PDFPROJECTSCHEME");
      acc.AddParameter("EXPORTFILE", fullFileName);
      acc.AddParameter("EXPORTSCHEME", "EPLAN_default_value");

      cli.Execute("export", acc);

      progress.EndPart(true);
    }
  }
}