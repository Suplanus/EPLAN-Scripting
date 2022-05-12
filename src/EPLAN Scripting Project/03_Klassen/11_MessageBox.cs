using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _03_Klassen_11_Messagebox
{
  [Start]
  public void Function()
  {
    string projectName = PathMap.SubstitutePath("$(PROJECTNAME)");

    MessageBox.Show("Text", projectName);

    MessageBox.Show(
        "Text",
        projectName,
        MessageBoxButtons.YesNo
        );

    MessageBox.Show(
        "Text",
        projectName,
        MessageBoxButtons.AbortRetryIgnore,
        MessageBoxIcon.Information
        );
  }
}