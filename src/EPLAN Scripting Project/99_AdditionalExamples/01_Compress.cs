using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _99_AdditionalExamples_01_Compress
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("CONFIGSCHEME", "Remove unnecessary project data");

    cli.Execute("compress", acc);

    MessageBox.Show("Action executed.");
  }
}