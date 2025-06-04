using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

class _99_Additional_10_SelectionSet
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();
    acc.AddParameter("TYPE", "PAGES");
    cli.Execute("selectionset", acc);

    string pagesString = string.Empty;
    acc.GetParameter("PAGES", ref pagesString);

    string[] pages = pagesString.Split(';');
    int pagesCount = pages.Length;

    MessageBox.Show("Count of selected files: " + pagesCount);
  }
}