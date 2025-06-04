using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _16_Export_03_PdfOnClosing
{
  [DeclareEventHandler("Eplan.EplApi.OnUserPreCloseProject")]
  public void Function()
  {
    string path = PathMap.SubstitutePath("$(DOC)");
    string projectName = PathMap.SubstitutePath("$(PROJECTNAME)");

    DialogResult dialogResult = MessageBox.Show(
        "Do you want export a PDF for project '" +
        projectName + "' ?",
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

      string fullFileName = Path.Combine(path, projectName);
      acc.AddParameter("TYPE", "PDFPROJECTSCHEME");
      acc.AddParameter("EXPORTFILE", fullFileName);
      acc.AddParameter("EXPORTSCHEME", "EPLAN_default_value");

      cli.Execute("export", acc);

      progress.EndPart(true);
    }
  }
}