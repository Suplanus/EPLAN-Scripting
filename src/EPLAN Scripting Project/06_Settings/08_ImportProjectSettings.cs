using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _08_ImportProjectSettings
{
  [Start]
  public void Function()
  {
    string scripts = PathMap.SubstitutePath("$(MD_SCRIPTS)" + @"\");
    string project = PathMap.SubstitutePath("$(P)");

    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();
    acc.AddParameter("Project", project);
    acc.AddParameter("XmlFile", scripts + @"Point.xml");
    cli.Execute("XSettingsImport", acc);

    MessageBox.Show("Settings have been imported.");
  }
}