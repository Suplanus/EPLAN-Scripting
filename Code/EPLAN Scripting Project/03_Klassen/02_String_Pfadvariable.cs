using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _03_Klassen_02_String_Pfadvariable
{
  [Start]
  public void Function()
  {
    string projectName = PathMap.SubstitutePath("$(PROJECTNAME)");
    MessageBox.Show(projectName);

    return;
  }
}