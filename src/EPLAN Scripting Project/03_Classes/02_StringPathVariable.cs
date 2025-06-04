using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _03_Classes_02_StringPathVariable
{
  [Start]
  public void Function()
  {
    string projectName = PathMap.SubstitutePath("$(PROJECTNAME)");
    MessageBox.Show(projectName);
  }
}