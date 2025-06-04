using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_CodeFlow_01_IfString
{
  [DeclareAction("IfString")]
  public void Function(string parameter)
  {
    if (parameter == "YES")
    {
      MessageBox.Show("yes");
    }
    else
    {
      MessageBox.Show("no");
    }

    if (parameter.ToUpper() == "YES")
    {
      MessageBox.Show("yes");
    }
    else
    {
      MessageBox.Show("no");
    }
  }
}